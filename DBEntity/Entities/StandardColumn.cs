namespace DBEntity.Entities
{
    /// <summary>
    /// 標準カラム
    /// </summary>
    public class StandardColumn
    {
        /// <summary>
        /// 作成日時
        /// </summary>
        public DateTime create_at { get; set; }

        /// <summary>
        /// 作成者
        /// </summary>
        public string? create_user { get; set; } = string.Empty;

        /// <summary>
        /// 作成プログラム
        /// </summary>
        public string create_program { get; set; } = string.Empty;

        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime update_at { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        public string? update_user { get; set; } = string.Empty;

        /// <summary>
        /// 更新プログラム
        /// </summary>
        public string update_program { get; set;} = string.Empty;
    }
}
