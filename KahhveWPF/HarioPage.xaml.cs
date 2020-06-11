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
    /// Interaction logic for HarioPage.xaml
    /// </summary>
    public partial class HarioPage : Window
    {
        public HarioPage()
        {
            InitializeComponent();

            //API erişim
            var url = "https://localhost:44354/api/products";
            var json = new WebClient().DownloadString(url);
            dynamic stuff = JsonConvert.DeserializeObject(json);

            //Ürünler için tool'lar
            Image[] images = { image1, image2, image3, image4 };
            Label[] titles = { title1, title2, title3, title4 };
            Label[] brands = { marka1, marka2, marka3, marka4 };
            Label[] prices = { price1, price2, price3, price4 };

            //Ürünleri sayfadaki yerlerine yerlerine atama
            var imageAdress = stuff[4].image.ToString();
            var title = stuff[4].title.ToString();
            var marka = stuff[4].marka.ToString();
            var price = stuff[4].price.ToString();
            var imageSrc = new Uri(imageAdress);
            images[0].Source = new BitmapImage(imageSrc);
            titles[0].Content = title;
            brands[0].Content = marka;
            prices[0].Content = price + " TL";

            imageAdress = stuff[5].image.ToString();
            title = stuff[5].title.ToString();
            marka = stuff[5].marka.ToString();
            price = stuff[5].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[1].Source = new BitmapImage(imageSrc);
            titles[1].Content = title;
            brands[1].Content = marka;
            prices[1].Content = price + " TL";

            imageAdress = stuff[6].image.ToString();
            title = stuff[6].title.ToString();
            marka = stuff[6].marka.ToString();
            price = stuff[6].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[2].Source = new BitmapImage(imageSrc);
            titles[2].Content = title;
            brands[2].Content = marka;
            prices[2].Content = price + " TL";

            imageAdress = stuff[10].image.ToString();
            title = stuff[10].title.ToString();
            marka = stuff[10].marka.ToString();
            price = stuff[10].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[3].Source = new BitmapImage(imageSrc);
            titles[3].Content = title;
            brands[3].Content = marka;
            prices[3].Content = price + " TL";
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

            Image[] images = { image1, image2, image3, image4 };
            Label[] titles = { title1, title2, title3, title4 };
            Label[] brands = { marka1, marka2, marka3, marka4 };
            Label[] prices = { price1, price2, price3, price4 };

            var imageAdress = stuff[5].image.ToString();
            var title = stuff[5].title.ToString();
            var marka = stuff[5].marka.ToString();
            var price = stuff[5].price.ToString();
            var imageSrc = new Uri(imageAdress);
            images[0].Source = new BitmapImage(imageSrc);
            titles[0].Content = title;
            brands[0].Content = marka;
            prices[0].Content = price + " TL";

            imageAdress = stuff[7].image.ToString();
            title = stuff[7].title.ToString();
            marka = stuff[7].marka.ToString();
            price = stuff[7].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[1].Source = new BitmapImage(imageSrc);
            titles[1].Content = title;
            brands[1].Content = marka;
            prices[1].Content = price + " TL";

            imageAdress = stuff[9].image.ToString();
            title = stuff[9].title.ToString();
            marka = stuff[9].marka.ToString();
            price = stuff[9].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[2].Source = new BitmapImage(imageSrc);
            titles[2].Content = title;
            brands[2].Content = marka;
            prices[2].Content = price + " TL";

            imageAdress = stuff[10].image.ToString();
            title = stuff[10].title.ToString();
            marka = stuff[10].marka.ToString();
            price = stuff[10].price.ToString();
            imageSrc = new Uri(imageAdress);
            images[3].Source = new BitmapImage(imageSrc);
            titles[3].Content = title;
            brands[3].Content = marka;
            prices[3].Content = price + " TL";
        }
    }
}
