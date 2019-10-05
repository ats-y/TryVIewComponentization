using System;
using System.Collections.Generic;
using TryContextMenu.Models;

namespace TryContextMenu.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 社員リスト
        /// </summary>
        private List<Employee> _employeeList;

        /// <summary>
        /// 社員リストプロパティ
        /// </summary>
        public List<Employee> EmployeeList
        {
            get { return _employeeList; }
            set { SetProperty(ref _employeeList, value); }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPageViewModel()
        {
            // 社員リストを生成する。
            _employeeList = new List<Employee>
            {
                new Employee { FullName = "社員 太郎" },
                new Employee { FullName = "社員 二郎" },
                new Employee { FullName = "社員 三郎" },
                new Employee { FullName = "社員 四郎" },
                new Employee { FullName = "社員 五郎" },
            };

        }
    }
}
