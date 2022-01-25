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
            //Random rnd = new Random();
            //int StartPoint = rnd.Next(0, 5000); // возможный рандом точки спавна игрока
            //ток прикол в стенах, которые обязателны ...

            try
            {
                if (TxbLogin.Text != null && TxbPassword.Text != null)
                {
                    User userAdd = new User
                    {
                        Login = TxbLogin.Text,
                        Password = TxbPassword.Text,
                        //IdPlayer = 1 - здесь должно быть что-то типа счетчика. При регистрации каждому новому пользователю
                        //               присваивать новый IdPlayer
                        
                        //PlayerLevel = 1,
                        //надо думать и менять 100% прописанное ниже
                        //idBuff = 6,
                        //idClass = 0,
                        //idCoords = 

                    };

                    var checkUser = ConnectData.gameDataset.User.Count(i => i.Login == TxbLogin.Text); // проверка наличия такого же игрока в БД
                    if (checkUser > 0)
                    {
                        MessageBox.Show("Игрок с таким логином уже зарегистрирован",
                                      "Уведомление",
                                      MessageBoxButton.OK,
                                      MessageBoxImage.Information);
                        return;
                    }

                    if (TxbLogin.Text != null && TxbPassword.Text != null)
                    {
                        ConnectData.gameDataset.User.Add(userAdd);
                        ConnectData.gameDataset.SaveChanges();
                        MessageBox.Show("Профиль успешно Зарегистрирован!",
                                            "Уведомление",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Заполните строки",
                                            "Ошибка",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Error);
                    }
                    NavFrame.navFrame.Navigate(new Autorization());
                } // конец блока проверки пустот в заполнении

                else
                {
                    MessageBox.Show("Ошибка", "Заполните все поля", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message.ToString(),
                    ex.Data.ToString(),
                    MessageBoxButton.OK,
                    MessageBoxImage.Stop);
            }
        } //конец кнопки регистрациии, всё ломалось из-за неё

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.navFrame.GoBack();
        }
    }
}
