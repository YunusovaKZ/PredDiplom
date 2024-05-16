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

namespace PredDiplom.Page
{
    /// <summary>
    /// Логика взаимодействия для AddGuriPage.xaml
    /// </summary>
    public partial class AddGuriPage : Window
    {
        PartyEntities party = new PartyEntities();
        public AddGuriPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            OrganizatorPage org = new OrganizatorPage();
            org.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            party.User.Add(new User()
            {
                Id = Convert.ToInt32(tbId.Text),
                Surname = tbSurname.Text,
                Name=tbName.Text,
                Birthday = (DateTime)tbDay.SelectedDate,
                Mail = tbMail.Text,
                Password = tbPass.Password,
                Pol = Convert.ToInt32(tbPol.Text),
                Role = Convert.ToInt32(tbRole.Text),
                Phone = Phone.Text,
                Photo = tbImg.Text
            });
            party.SaveChanges();

            this.Close();
        }
    }
}
