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
    /// <summary>
    /// Логика взаимодействия для AdmMenu.xaml
    /// </summary>
    public partial class AdmMenu : Page
    {
        public AdmMenu()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            using (var context = new Pz1ZyryanovaDaContext())
            {
                // Получаем список пользователей из базы данных
                List<User> users = context.Users.ToList();

                // Привязываем список к DataGrid
                userGrid.ItemsSource = users;
            }
        }
    }
}
