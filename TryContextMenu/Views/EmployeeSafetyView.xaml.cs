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

        List<ActionEvent> _myValue;
        public List<ActionEvent> MyValue
        {
            get { return _myValue; }
            set
            {
                Debug.WriteLine("MyVlaue set property");
                _myValue = value;

                if (_myValue == null) return;
                foreach(ActionEvent ae in _myValue)
                {
                    HistoryArea.Children.Add(
                        new Label
                        {
                            Text = ae.Content,
                            BackgroundColor = Color.Aqua,
                        });
                }
            }
        }

        public static readonly BindableProperty MyValueProperty =
            BindableProperty.Create(
                nameof(MyValue),
                typeof(List<ActionEvent>),
                typeof(EmployeeSafetyView),
                null,
                propertyChanged: (bindblable, oldValue, newValue) =>
                {
                    Debug.WriteLine("MyValueProperty Property Changed!");
                    ((EmployeeSafetyView)bindblable).MyValue = (List<ActionEvent>)newValue;
                },
                defaultBindingMode: BindingMode.TwoWay
            );
    }
}
