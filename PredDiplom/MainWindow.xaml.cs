﻿using PredDiplom.Page;
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

namespace PredDiplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PartyEntities party = new PartyEntities();
        public MainWindow()
        {
            InitializeComponent();

            dgMerop.ItemsSource = party.Meropriyatiya.ToList();

        }

        private void btnAvto_Click(object sender, RoutedEventArgs e)
        {
            Avtorizatiya avto = new Avtorizatiya();
            avto.Show();
            this.Close();
        }
    }
}
