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
using System.Xml.Linq;
using Pool.Models;


namespace Pool.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddNoteAbonement.xaml
    /// </summary>
    public partial class WindowAddNoteAbonement : Window
    {
        public string NameCategory { get; set; }
        public string QuantityNumberVisit {get; set;}
        public int Price { get; set; }

        public WindowAddNoteAbonement()
        {
            InitializeComponent();


            CmbCategory.DisplayMemberPath = "Name";
            CmbCategory.SelectedValuePath = "Id";
            CmbCategory.ItemsSource = ConnectDb.Connect.Categories.ToList();
            //NameCategory = TxbCategory.Text as Category.Name;
            //QuantityNumberVisit = NumberVisit;
            //Price = int.Parse(TxbPrice.Text);
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Abonement abonement = new Abonement()
                {
                    //Number = TxbNumber.Text,
                    //Category = NameCategory,
                    //NumberVisit = QuantityNumberVisit,
                    //Price = Price,
                    
                };

                ConnectDb.Connect.Abonements.Add(abonement);
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
