using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Pool.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddNote.xaml
    /// </summary>
    public partial class WindowAddNoteUser : Window
    {
        public List<User> Users = ConnectDb.Connect.Users.ToList();
        public WindowAddNoteUser()
        {
            InitializeComponent(); 

            CmbAbonement.DisplayMemberPath = "Number";
            CmbAbonement.SelectedValuePath = "Id";
            CmbAbonement.ItemsSource = ConnectDb.Connect.Abonements.ToList();

        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Name = TxbName.Text,
                    Surname = TxbSurname.Text,
                    Patronomic = TxbPatronomic.Text,
                    Phone = TxbPhone.Text,
                    Abonement = CmbAbonement.SelectedItem as Abonement,
                };

                ConnectDb.Connect.Users.Add(user);
                ConnectDb.Connect.SaveChanges();
                MessageBox.Show("Запись создана успешно", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();

            }
            catch(Exception)
            {
                MessageBox.Show("Заполнены не все поля",
                    "Критическая ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                    );
            }
        }
    }
}
