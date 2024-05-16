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
    /// Логика взаимодействия для OrganizatorPage.xaml
    /// </summary>
    public partial class OrganizatorPage : Window
    {
        public OrganizatorPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnGuri_Click(object sender, RoutedEventArgs e)
        {
            AddGuriPage guri = new AddGuriPage();
            guri.Show();
            this.Close();
        }
    }
}
