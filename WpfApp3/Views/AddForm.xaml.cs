using System.Windows;
using WpfApp3.BusinessLogic;
using WpfApp3.Models;

namespace WpfApp3.Views
{
    /// <summary>
    /// Логика взаимодействия для AddForm.xaml
    /// </summary>
    public partial class AddForm : Window
    {
        HumanService _humanService = new HumanService();
        public AddForm()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _humanService.Add(new Human { Sername = TextBoxSername.Text, Name= TextBoxName.Text, Pathronymic = TextBoxPathronymic.Text });
            TextBoxSername.Clear();
            TextBoxName.Clear();
            TextBoxPathronymic.Clear();
        }
    }
}
