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
using Dungeon.Data.Dataset;
using Dungeon.Data.Classes;

namespace Dungeon.MainPages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var objPlayer = ConnectData.gameDataset.Player
                .FirstOrDefault(x => x.Login == TxbLogin.Text
                && x.Password == PsbPassword.Password);
            if (objPlayer != null)
            {
                PlayerInfo.player = objPlayer;
                MessageBox.Show("Добро пожаловать в Средиземье");
            }
        }
    }
}
