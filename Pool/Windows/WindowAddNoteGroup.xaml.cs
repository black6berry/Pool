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
    /// Логика взаимодействия для WindowAddNoteGroup.xaml
    /// </summary>
    public partial class WindowAddNoteGroup : Window
    {
        public WindowAddNoteGroup()
        {
            InitializeComponent();
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Group group = new Group()
                {
                    //Number = TxbNumber.Text,
                    //Category = NameCategory,
                    //NumberVisit = QuantityNumberVisit,
                    //Price = Price,

                };

                ConnectDb.Connect.Groups.Add(group);
                ConnectDb.Connect.SaveChanges();
                MessageBox.Show("Запись создана успешно", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();

            }
            catch (Exception)
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
