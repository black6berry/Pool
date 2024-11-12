using Pool.Models;
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
    /// Логика взаимодействия для PageUsers.xaml
    /// </summary>
    public partial class PageUsers : Page
    {
        public PageUsers()
        {
            InitializeComponent();

            // добавить пользоватплей в список
            GridUserList.ItemsSource = ConnectDb.Connect.Users.ToList();
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
    }
}
