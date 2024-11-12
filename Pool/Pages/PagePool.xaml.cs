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
    /// Логика взаимодействия для PagePool.xaml
    /// </summary>
    public partial class PagePool : Page
    {
        public PagePool()
        {
            InitializeComponent();

            // Добавить Басейны в список
            GridPoolList.ItemsSource = ConnectDb.Connect.Pools.ToList();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e) => new WindowAddNotePool().Show();
        

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
