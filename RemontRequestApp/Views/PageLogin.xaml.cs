using RemontRequestApp.Classes.Connection;
using RemontRequestApp.Classes.Navigation;
using RemontRequestApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RemontRequestApp.Views
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        private List<User> _users;

        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                _users = Connecting.entities.User.ToList();
                if (_users.Count > 0)
                {
                    NavigateToHomePage(TbLogin.Text, TbPass.Password);
                }
                else
                {
                    MessageBox.Show("Возникла внутренняя ошибка, в системе нет пользователей", "Внутренняя ошибка");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Возникла ошибка");
                throw;
            }
        }

        private void NavigateToHomePage(string login, string password)
        {
            try
            {
                var user = _users.Where(u => u.Login == login).FirstOrDefault();

                if (user != null && user.Password == password)
                {
                    switch (user.RoleId)
                    {
                        case 1:
                            Navigator.Navigate.Navigate(new ManagerMainPage());
                            break;
                        case 2:
                            Navigator.Navigate.Navigate(new MasterMainPage());
                            break;
                        case 3:
                            Navigator.Navigate.Navigate(new OperatorMainPage());
                            break;
                        case 4:
                            Navigator.Navigate.Navigate(new CustomerMainPage());
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");
                throw;
            }
        }
    }
}
