using Pool.Models;
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
using System.Windows.Shapes;

namespace Pool.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddNoteTrener.xaml
    /// </summary>
    public partial class WindowAddNoteTrener : Window
    {
        public List<Group> Groups = ConnectDb.Connect.Groups.ToList();
        public WindowAddNoteTrener()
        {
            InitializeComponent();

            CmbCategory.DisplayMemberPath = "Number";
            CmbCategory.SelectedValuePath = "Id";
            CmbCategory.ItemsSource = ConnectDb.Connect.Groups.ToList();
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
