using Pool.Windows;
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

namespace Pool.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTrener.xaml
    /// </summary>
    public partial class PageTrener : Page
    {
        public PageTrener()
        {
            InitializeComponent();

            // добавить тренеров в список
            GridTrenerList.ItemsSource = ConnectDb.Connect.Treners.ToList();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e) => new WindowAddNoteTrener().Show();
        

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
