using System.Windows;
using System.Windows.Controls;
using WpfApp3.Models;
using WpfApp3.BusinessLogic;
using WpfApp3.Views;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HumanService _humanService = new HumanService();

        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = _humanService.Get();
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }
        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = _humanService.Get();
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0 && MessageBox.Show("Подтвержение удаления", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Human? human = DataGrid.SelectedItems[i] as Human;
                    if (human != null)
                    {
                        _humanService.Delete(human);
                    }
                }
            }
        }
        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Human? human = DataGrid.SelectedItems[i] as Human;
                    if (human != null)
                    {
                        UpdateForm update = new UpdateForm();
                        update.ShowData(human);
                        update.Show();
                    }
                }
            }
        }
    }
}
