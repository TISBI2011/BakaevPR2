using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace
BakaevPR2.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddP.xaml
    /// </summary>
    public partial class AddP : Page
    {
        public AddP()
        {
            InitializeComponent();
            TypeCB.ItemsSource = App.DB.typeF.ToList();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserP());
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            //Поиск id типа
            typeF tf = new typeF();
            var Cl = App.DB.typeF.Where(a => a.nameT == TypeCB.Text);
            if (Cl.Any() == true)
            {
                foreach (typeF c in Cl)
                {
                    tf.id = c.id;
                }
            }
            else
            {
                MessageBox.Show("Enter Class");
                count++;
            }
            furniture f = new furniture();
            try
            {
                f.name = NameTB.Text;
                f.material = MaterialTB.Text;
                f.style = StyleTB.Text;
                f.count = Convert.ToInt32(CountTB.Text);
                f.idType = tf.id;

            }
            catch
            {
                count++;
                MessageBox.Show("Введён неверный формат");
            }
            if (count == 0)
            {
                App.DB.furniture.Add(f);
                App.DB.SaveChanges();
                MessageBox.Show("Added!");
            }

        }
    }
}
