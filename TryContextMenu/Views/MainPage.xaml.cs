using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryContextMenu.Models;
using Xamarin.Forms;

namespace TryContextMenu
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
          InitializeComponent();
        }

        /// <summary>
        /// 削除コンテキストメニュークリックのイベントハンドラ。
        /// </summary>
        /// <param name="sender">クリックされたMenuItem。</param>
        /// <param name="e">なし。</param>
        void OnDeleteMenuClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("OnDeleteMenuClicked");

            // クリックされたMenuItemに紐づいている社員オブジェクトを取得する。
            MenuItem target = sender as MenuItem;
            if (target == null) return;
            Employee emp = target.BindingContext as Employee;
            if (emp == null) return;

            // ダイアログでコンテキストメニューを表示した行の社員名を表示する。
            DisplayAlert(target.Text,
                string.Format($"{emp.FullName}の削除コンテキストメニューがクリックされました。"), "ok");
        }
    }
}
