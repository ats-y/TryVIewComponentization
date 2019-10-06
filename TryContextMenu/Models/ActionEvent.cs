using System;
namespace TryContextMenu.Models
{
    /// <summary>
    /// 行動クラス
    /// </summary>
    public class ActionEvent
    {
        /// <summary>
        /// 行動した日時
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 行動内容
        /// </summary>
        public string Content { get; set; }

        public bool IsActive { get; set; } = false;

        public ActionEvent()
        {
        }
    }
}
