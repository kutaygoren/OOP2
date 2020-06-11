using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace KahhveWPF
{
    /// <summary>
    /// Interaction logic for coffeeSapiens.xaml
    /// </summary>
    public partial class coffeeSapiens : Window
    {
        public coffeeSapiens()
        {
            InitializeComponent();

            var url = "https://localhost:44354/api/products";
            var json = new WebClient().DownloadString(url);
            dynamic stuff = JsonConvert.DeserializeObject(json);

            //Ürünler için tool'lar
            Image[] images = { image1 };
            Label[] titles = { title1 };
            Label[] brands = { marka1 };
            Label[] prices = { price1 };

            var imageAdress = stuff[9].image.ToString();
            var title = stuff[11].title.ToString();
            var marka = stuff[11].marka.ToString();
            var price = stuff[11].price.ToString();
            var imageSrc = new Uri(imageAdress);
            images[0].Source = new BitmapImage(imageSrc);
            titles[0].Content = title;
            brands[0].Content = marka;
            prices[0].Content = price + " TL";
        }

        private void kahhvelerPage_MouseDown(object sender, MouseEventArgs e)
        {
            Kahhveler kahhveler = new Kahhveler();
            this.Close();
            kahhveler.Show();
        }

        private void giris_MouseDown(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void kahhveler_MouseDown(object sender, MouseEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void aboneOl_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Aboneliğiniz Alınmıştır!");
        }

        private void hakkimizda_MouseDown(object sender, MouseEventArgs e)
        {
            Hakkimizda hakkimizda = new Hakkimizda();
            this.Close();
            hakkimizda.Show();
        }

        private void hario_MouseDown(object sender, MouseEventArgs e)
        {
            HarioPage harioPage = new HarioPage();
            this.Close();
            harioPage.Show();
        }
    }
}
