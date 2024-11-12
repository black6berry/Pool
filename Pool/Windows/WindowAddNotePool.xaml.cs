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
    /// Логика взаимодействия для WindowAddNotePool.xaml
    /// </summary>
    public partial class WindowAddNotePool : Window
    {
        public List<Category> Cotegories = ConnectDb.Connect.Categories.ToList();
        public List<Trener> Treners = ConnectDb.Connect.Treners.ToList();
        public WindowAddNotePool()
        {
            InitializeComponent();

            CmbCategory.DisplayMemberPath = "Name";
            CmbCategory.SelectedValuePath = "Id";
            CmbCategory.ItemsSource = ConnectDb.Connect.Categories.ToList();

            CmbTrener.DisplayMemberPath = "SNP";
            CmbTrener.SelectedValuePath = "Id";
            CmbTrener.ItemsSource = ConnectDb.Connect.Treners.ToList();
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
