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

namespace KahhveWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
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

        private void hakkimizda_MouseDown(object sender, MouseEventArgs e)
        {
            Hakkimizda hakkimizda = new Hakkimizda();
            this.Close();
            hakkimizda.Show();
        }

        public static class Accounts
        {
            public static string mail { get; set; }
            public static string password { get; set; }
            public static string passwordCheck { get; set; }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (Accounts.mail == tbxMail.Text && Accounts.password == tbxPassword.Password)
            {
                MessageBox.Show("Giriş Başarılı!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı Hatalı!");
            }
        }

        private void signUp_MouseDown(object sender, MouseEventArgs e)
        {
            Accounts.mail = tbxMail_signUp.Text;
            Accounts.password = tbxPassword_signUp.Password;
            Accounts.passwordCheck = tbxPassword_signUp2.Password;

            if (Accounts.password == Accounts.passwordCheck)
            {
                gridSignUp.Visibility = Visibility.Hidden;
                MessageBox.Show("Kayıt Başarılı!");
            }

            else
            {
                MessageBox.Show("Şifreniz eşleşmiyor!");
            }
        }

        private void kahhvelerPage_MouseDown(object sender, MouseEventArgs e)
        {
            Kahhveler kahhveler = new Kahhveler();
            this.Close();
            kahhveler.Show();
        }
    }
}
