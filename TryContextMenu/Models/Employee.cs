using System;
using System.Collections.Generic;

namespace TryContextMenu.Models
{
    /// <summary>
    /// 社員クラス。
    /// </summary>
    public class Employee
    {
        public Employee()
        {
        }

        /// <summary>
        /// 社員名。
        /// </summary>
        public string FullName { get; set; }

        public List<ActionEvent> MyValue { get; set; }


    }
}
