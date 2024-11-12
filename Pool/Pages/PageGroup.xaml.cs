using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pool.Windows;

namespace Pool.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageGroup.xaml
    /// </summary>
    public partial class PageGroup : Page
    {
        public PageGroup()
        {
            InitializeComponent();

            // добавление басейнов в список
            GridGroupList.ItemsSource = ConnectDb.Connect.Groups.ToList();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e) => new WindowAddNoteGroup().Show();

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
