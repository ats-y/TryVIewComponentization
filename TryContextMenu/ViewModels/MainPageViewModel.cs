using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using TryContextMenu.Models;
using Xamarin.Forms;

namespace TryContextMenu.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 社員リスト
        /// </summary>
        private ObservableCollection<Employee> _employeeList;

        /// <summary>
        /// 社員リストプロパティ
        /// </summary>
        public ObservableCollection<Employee> EmployeeList
        {
            get { return _employeeList; }
            set { SetProperty(ref _employeeList, value); }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPageViewModel()
        {
            Title = "aaa";

            // 社員リストを生成する。
            _employeeList = new ObservableCollection<Employee>
            {
                new Employee
                {
                    FullName = "社員 太郎",
                    ActionHistoryList = new List<ActionEvent>{
                        new ActionEvent
                        {
                            Time = DateTime.Now,
                            Content = "出社",
                        },
                        new ActionEvent
                        {
                            Time = DateTime.Now,
                            Content = "外出",
                        } },
                },
                new Employee { FullName = "社員 二郎" },
                new Employee
                {
                    FullName = "社員 三郎",
                    ActionHistoryList = new List<ActionEvent>{
                        new ActionEvent
                        {
                            Time = DateTime.Now,
                            Content = "出社",
                        },
                        new ActionEvent
                        {
                            Time = DateTime.Now,
                            Content = "帰宅",
                        } },
                },
                new Employee { FullName = "社員 四郎" },
                new Employee { FullName = "社員 五郎" },
            };
        }

        /// <summary>
        /// 社員リストから引数で指定した社員を削除する。
        /// </summary>
        public ICommand DeleteCommand =>
            new Command<Employee>((arg) =>
        {
            Debug.WriteLine("MainPage.DeleteCommand()");

            EmployeeList.Remove(arg);
        });
    }
}
