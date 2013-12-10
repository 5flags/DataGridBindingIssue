using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(string))
            {
                var col = new DataGridTextColumn {Binding = new Binding(e.PropertyName), Header = e.PropertyName};
                e.Column = col;
            }
            else if (e.PropertyType == typeof(DataItem))
            {
                var col = new DataGridTemplateColumn
                {
                    CellTemplate = (DataTemplate) TheDataGrid.FindResource("dataItemCellTemplate"),
                    CellEditingTemplate = (DataTemplate)TheDataGrid.FindResource("dataItemCellTemplate"),
                    Header = e.PropertyName
                };
                e.Column = col;
            }
        }
    }
}
