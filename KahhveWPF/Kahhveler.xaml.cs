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
    /// Interaction logic for Kahhveler.xaml
    /// </summary>
    public partial class Kahhveler : Window
    {
        public Kahhveler()
        {
            InitializeComponent();

            //API erişim
            var url = "https://localhost:44354/api/products";
            var json = new WebClient().DownloadString(url);
            dynamic stuff = JsonConvert.DeserializeObject(json);

            //Ürünler için tool'lar
            Image[] images = { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12 };
            Label[] titles = { title1, title2, title3, title4, title5, title6, title7, title8, title9, title10, title11, title12 };
            Label[] brands = { marka1, marka2, marka3, marka4, marka5, marka6, marka7, marka8, marka9, marka10, marka11, marka12 };
            Label[] prices = { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };

            //Ürünleri sayfadaki yerlerine yerlerine atama
            for (int i = 0; i < images.Length; i++)
            {
                var imageAdress = stuff[i].image.ToString();
                var title = stuff[i].title.ToString();
                var marka = stuff[i].marka.ToString();
                var price = stuff[i].price.ToString();
                var imageSrc = new Uri(imageAdress);
                images[i].Source = new BitmapImage(imageSrc);
                titles[i].Content = title;
                brands[i].Content = marka;
                prices[i].Content = price + " TL";
            }
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

        private void sapiens_MouseDown(object sender, MouseEventArgs e)
        {
            coffeeSapiens sapiensPage = new coffeeSapiens();
            this.Close();
            sapiensPage.Show();
        }

        private void Sıralama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var url = "https://localhost:44354/api/products";
            var json = new WebClient().DownloadString(url);
            dynamic stuff = JsonConvert.DeserializeObject(json);

            int n = 12;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (stuff[j].price > stuff[j + 1].price)
                    {
                        // swap temp and arr[i] 
                        var temp = stuff[j];
                        stuff[j] = stuff[j + 1];
                        stuff[j + 1] = temp;
                    }
                }
            }

            Image[] images = { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12 };
            Label[] titles = { title1, title2, title3, title4, title5, title6, title7, title8, title9, title10, title11, title12 };
            Label[] brands = { marka1, marka2, marka3, marka4, marka5, marka6, marka7, marka8, marka9, marka10, marka11, marka12 };
            Label[] prices = { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };

            for (int i = 0; i < images.Length; i++)
            {
                var imageAdress = stuff[i].image.ToString();
                var title = stuff[i].title.ToString();
                var marka = stuff[i].marka.ToString();
                var price = stuff[i].price.ToString();
                var imageSrc = new Uri(imageAdress);
                images[i].Source = new BitmapImage(imageSrc);
                titles[i].Content = title;
                brands[i].Content = marka;
                prices[i].Content = price + " TL";
            }
        }
    }
}
