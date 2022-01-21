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
using WpfAgentstwo.CoreMyApp;

namespace WpfAgentstwo.AllPages
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
        }
        
        private void BtnIn_Click(object sender, RoutedEventArgs e)
        {
            var objUsers = ConnectToSQL.entConnect.Users
                .FirstOrDefault(x => x.Login == TxtIn.Text
                             && x.Password == TxtPass.Text);

            if (objUsers != null)
            {
                switch (objUsers.IdRole)
                {
                    case 1:
                        UsersInfo.usersInfo = objUsers;
                        MessageBox.Show("Меню для пасхалки / тестовой роли будет позже");
                        break;
                    case 2:
                        UsersInfo.usersInfo = objUsers;
                        //MessageBox.Show("Меню сотрудника будет позже");
                        DataL.MainFrame.Navigate(new PageMenu());
                        break;
                    case 3:
                        UsersInfo.usersInfo = objUsers;
                        MessageBox.Show("Меню клиента будет позже");
                        break;
                }
            }
        }
        
    }
}
