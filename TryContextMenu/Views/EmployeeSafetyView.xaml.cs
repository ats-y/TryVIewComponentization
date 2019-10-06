using System;
using System.Collections.Generic;
using System.Diagnostics;
using TryContextMenu.Models;
using Xamarin.Forms;

namespace TryContextMenu.Views
{
    public partial class EmployeeSafetyView : ContentView
    {
        public EmployeeSafetyView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 行動履歴
        /// </summary>
        List<ActionEvent> _actionHistoryList;

        /// <summary>
        /// 行動履歴プロパティ
        /// </summary>
        public List<ActionEvent> ActionHistoryList
        {
            get { return _actionHistoryList; }
            set
            {
                Debug.WriteLine("MyVlaue set property");

                // メンバ変数にセット。
                _actionHistoryList = value;

                // 行動履歴分Labelを追加していく。
                if (_actionHistoryList == null) return;
                foreach (ActionEvent ae in _actionHistoryList)
                {
                    // 行動履歴を表示するラベルを生成する。
                    Label label = new Label
                    {
                        Text = ae.Content,
                        BackgroundColor = Color.Aqua,
                    };

                    // タップイベント生成し、行動履歴ラベルに設定。
                    TapGestureRecognizer tgr = new TapGestureRecognizer();
                    tgr.Tapped += (sender, e) =>
                    {
                        Label lbl = sender as Label;
                        if (lbl == null) return;

                        // フラグを切り替え、背景色を変える。
                        ae.IsActive = !(ae.IsActive);
                        lbl.BackgroundColor = ae.IsActive ? Color.Aquamarine : Color.Aqua;
                    };
                    label.GestureRecognizers.Add(tgr);

                    // 行動履歴リストを表示するエリアにラベルを追加する。
                    HistoryArea.Children.Add(label);
                }
            }
        }

        /// <summary>
        /// 紐付け可能な「ActionHistoryList」プロパティの定義。
        /// </summary>
        public static readonly BindableProperty ActionHistoryListProperty =
            BindableProperty.Create(
                nameof(ActionHistoryList),  // プロパティ名
                typeof(List<ActionEvent>),  // プロパティの型
                typeof(EmployeeSafetyView),
                null, // 初期値
                propertyChanged: (bindblable, oldValue, newValue) =>
                {
                    Debug.WriteLine("MyValueProperty Property Changed!");
                    ((EmployeeSafetyView)bindblable).ActionHistoryList = (List<ActionEvent>)newValue;
                },
                defaultBindingMode: BindingMode.TwoWay
            );
    }
}
