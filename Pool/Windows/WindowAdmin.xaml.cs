using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
using Pool.Models;
using Pool.Pages;
using Pool.Windows;

namespace Pool
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        //public List<User> users { get; set; }


        public WindowAdmin()
        {
            InitializeComponent();

            FrameApp.Navigation = FrmGrid;

            // добавить пользоватплей в список
            GridUserList.ItemsSource = ConnectDb.Connect.Users.ToList();

        }

        private void Pool_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid.Navigate(new PagePool());
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid.Navigate(new PageUsers());
        }

        private void Trener_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid.Navigate(new PageTrener());
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid.Navigate(new PageGroup());
        }

        private void Abonement_Click(object sender, RoutedEventArgs e)
        {
            FrmGrid.Navigate(new PageAbonement());
        }

        private void TxbSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TxbSearch.Clear();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e) => new WindowAddNoteUser().Show();

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить данные?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    for (int i = 0; i < GridUserList.SelectedItems.Count; i++)
                    {
                        User dataObj = GridUserList.SelectedItems[i] as User;
                        ConnectDb.Connect.Users.Remove(dataObj);
                    }

                    ConnectDb.Connect.SaveChanges();
                    GridUserList.ItemsSource = ConnectDb.Connect.Users.ToList();
                    MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Критическая обработка");
            }


        }
        // Поиск по записям
        private void TxbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            /* Feature code */  
        }
       
        
    }
}
