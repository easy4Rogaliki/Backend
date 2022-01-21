using Dungeon.Data.Classes;
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
using Dungeon.MainPages;

namespace Dungeon.MainPages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void BtnSingle_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.navFrame.Navigate(new Autorization());
        }
        

        private void BtnMany_Click(object sender, RoutedEventArgs e)
        {
            NavFrame.navFrame.Navigate(new Autorization());
        }
    }
}
