using System.Windows;
using System.Windows.Controls;
using WpfApp3.Models;
using WpfApp3.BusinessLogic;
using WpfApp3.Views;

namespace WpfApp3.Views
{
    /// <summary>
    /// Логика взаимодействия для UpdateForm.xaml
    /// </summary>
    public partial class UpdateForm : Window
    {
        HumanService _humanService = new HumanService();
        Human _humanToUpdate;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void ShowData(Human human)
        {
            TextBoxSername.Text = human.Sername;
            TextBoxName.Text = human.Name;
            TextBoxPathronymic.Text = human.Pathronymic;
            _humanToUpdate = human;
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            _humanToUpdate.Sername = TextBoxSername.Text;
            _humanToUpdate.Name = TextBoxName.Text;
            _humanToUpdate.Pathronymic = TextBoxPathronymic.Text;
            _humanService.Update(_humanToUpdate);
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
