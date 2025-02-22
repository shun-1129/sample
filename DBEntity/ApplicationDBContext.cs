using DBEntity.Entities.Transaction;
using Microsoft.EntityFrameworkCore;

namespace DBEntity
{
    public class ApplicationDBContext : DbContext
    {
        #region メンバ変数
        /// <summary>
        /// DB接続情報
        /// </summary>
        private string _connectInfo = string.Empty;
        #endregion

        #region コンストラクタ
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        /// <param name="connentInfo">DB接続情報</param>
        public ApplicationDBContext ( string connentInfo ) { _connectInfo = connentInfo; }
        #endregion

        /// <summary>
        /// DB接続設定
        /// </summary>
        /// <param name="optionsBuilder">オプションビルダー</param>
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            // DB接続
            optionsBuilder.UseNpgsql ( _connectInfo );
            // 時間設定
            AppContext.SetSwitch ( "Npgsql.EnableLegacyTimestampBehavior" , true );
        }

        /// <summary>
        /// モデル作成
        /// </summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<t_plc_request> ( e =>
            {
                e.HasKey ( x => x.id );
                e.Property ( x => x.content ).HasColumnType ( "jsonb" );
            } );
        }
    }
}
