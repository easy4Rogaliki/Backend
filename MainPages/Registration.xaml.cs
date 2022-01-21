using Dungeon.Data.Classes;
using Dungeon.Data.Dataset;
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
using Dungeon.Data;

namespace Dungeon.MainPages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int StartPoint = rnd.Next(0, 5000); // возможный рандом точки спавна игрока
            //ток прикол в стенах, которые обязателны ...

            if  (TxbLogin.Text != null && TxbPassword.Text !=  null)
            {
                Player playerAdd = new Player
                {
                    Login = TxbLogin.Text,
                    Password = TxbPassword.Text,
                    PlayerLevel = 1,

                    //надо думать и менять 100% прописанное ниже
                    idBuff = 0,
                    idClass = 0,
                    idCoords = StartPoint,

                    
                };
                var checkPlayer = ConnectData.gameDataset.Player.Count(i => i.Login == TxbLogin.Text); // проверка наличия такого же игрока
                if (checkPlayer > 0)
                { MessageBox.Show("Игрок с таким логином уже зарегистрирован",
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information); 
                    return; 
                }
            } // конец блока проверки пустот в заполнении

            else
            {
                MessageBox.Show("Ошибка", "Заполните все поля", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        } //конец кнопки регистрациии, всё ломалось из-за неё

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Data.Classes.NavFrame.navFrame.GoBack();
        }


    }
}
