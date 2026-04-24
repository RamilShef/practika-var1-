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

namespace Varyant1
{
    /// <summary>
    /// Логика взаимодействия для ProizvoditelWindow.xaml
    /// </summary>
    public partial class ProizvoditelWindow : Window
    {
        public ProizvoditelWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Profil_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал на стадии разработки");
        }

        private void Zayavki_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал на стадии разработки");
        }
    }
}
