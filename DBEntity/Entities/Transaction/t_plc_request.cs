using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace DBEntity.Entities.Transaction
{
    /// <summary>
    /// PLC要求テーブル
    /// </summary>
    [Table ( "t_plc_request" )]
    public class t_plc_request : StandardColumn
    {
        /// <summary>
        /// PLC要求ID
        /// </summary>
        [Key]
        public long id { get; set; }

        /// <summary>
        /// 命令
        /// </summary>
        public int command { get; set; }

        /// <summary>
        /// 命令状態
        /// </summary>
        public int command_status { get; set; }

        /// <summary>
        /// 命令内容
        /// </summary>
        public JsonDocument content { get; set; }
    }
}
