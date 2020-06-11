using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
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
using System.ComponentModel;
using System.Net;
using Newtonsoft.Json;

namespace KahhveWPF
{
    /// <summary>
    /// Interaction logic for Hakkimizda.xaml
    /// </summary>
    public partial class Hakkimizda : Window
    {
        public Hakkimizda()
        {
            InitializeComponent();
        }

        private void aboneOl_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Aboneliğiniz Alınmıştır!");
        }

        private void kahhveler_MouseDown(object sender, MouseEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void giris_MouseDown(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void kahhvelerPage_MouseDown(object sender, MouseEventArgs e)
        {
            Kahhveler kahhveler = new Kahhveler();
            this.Close();
            kahhveler.Show();
        }
    }
}
