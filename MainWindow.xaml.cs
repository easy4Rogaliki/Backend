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

namespace Dungeon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //еееееее а вы куда уехали?fff
            Console.WriteLine("Здравствуйте, мы начинаем наше новое шоу ");

            MessageBox.Show("Памагите","Уведомление", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
        }


    }
}
