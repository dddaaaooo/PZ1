using Microsoft.EntityFrameworkCore;
using PZ1_ZyryanovaDA.Models;
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

namespace PZ1_ZyryanovaDA.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEmail.Text) && !String.IsNullOrEmpty(tbPassword.Text))
                LoginUser();
            else
               MessageBox.Show("Пожалуйста, введите почту и пароль", "Предупреждение");
        }

        private void LoginUser()
        {
            string email = tbEmail.Text.Trim();
            string password = HashPasswords.Hash(tbPassword.Text.Trim().Replace("\"", ""));

            var context = new Pz1ZyryanovaDaContext();
            var user = context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (user != null)
            {
                MessageBox.Show("успешный вход");
                NavigationService.Navigate(new AdmMenu());
            }
            else
                MessageBox.Show("ошибка почты или пароля");
        }
    }
}
