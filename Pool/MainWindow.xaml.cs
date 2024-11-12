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

namespace Pool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {   //Проверка логина и пароля
                var data = ConnectDb.Connect.Users.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Pasword == PsbPassword.Password);

                if (data != null)
                {
                    MessageBox.Show($"Добро пожаловать в систему, {data.Name})) ");
                    WindowAdmin windowAdmin = new WindowAdmin();
                    windowAdmin.ShowDialog();

                }
            }
            catch
            {
                MessageBox.Show("Данные введены некоректно");
            }
        }
    
    }
}
