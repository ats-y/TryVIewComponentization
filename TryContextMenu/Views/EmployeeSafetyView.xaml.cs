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

        ActionEvent _myValue;
        public ActionEvent MyValue
        {
            get { return _myValue; }
            set
            {
                Debug.WriteLine("MyVlaue set property");
                _myValue = value;

                HistoryArea.Children.Add(
                    new Label
                    {
                        Text = MyValue.Content,
                    });
            }
        }

        public static readonly BindableProperty MyValueProperty =
            BindableProperty.Create(
                nameof(MyValue),
                typeof(ActionEvent),
                typeof(EmployeeSafetyView),
                null,
                propertyChanged: (bindblable, oldValue, newValue) =>
                {
                    Debug.WriteLine("MyValueProperty Property Changed!");
                    ((EmployeeSafetyView)bindblable).MyValue = (ActionEvent)newValue;
                },
                defaultBindingMode: BindingMode.TwoWay
            );
    }
}
