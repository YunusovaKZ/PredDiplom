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
    /// Логика взаимодействия для Avtorizatiya.xaml
    /// </summary>
    public partial class Avtorizatiya : Window
    {
        PartyEntities party = new PartyEntities();
        public Avtorizatiya()
        {
            InitializeComponent();
        }

        private void btnAvto_Click(object sender, RoutedEventArgs e)
        {
            var i = Convert.ToInt32(tbId.Text);
            var user = party.User.Where(u => u.Id == i && u.Password == tbPassword.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
            else
            {
                switch (user.Role)
                {
                    case 0:
                        GuriPage guri = new GuriPage();
                        guri.Show();
                        this.Close();
                        break;
                    case 1:
                        MenedgerPage men = new MenedgerPage();
                        men.ShowDialog();
                        this.Close();
                        break;
                    case 2:
                        UchastnikPage uchast = new UchastnikPage();
                        uchast.Show();
                        this.Close();
                        break;
                    case 3:
                        OrganizatorPage org = new OrganizatorPage();
                        org.Show();
                        this.Close();
                        break;
                }
            }
        }
    }
}
