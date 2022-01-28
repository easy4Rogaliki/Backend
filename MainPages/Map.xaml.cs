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

namespace Dungeon.MainPages
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        public Map()
        {
            InitializeComponent();
        }


        // 10000 значений координат всего / 5000 клеточек
        // 592 на стены по периметру
        // 4 408 на остальные клетки и свойства
        // while id <= 300:
        // поставить стены


        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DrawGameArea();
        }

        private void DrawGameArea()
        {
            int CooX = 0, CooY = 0;

        }
    }
}
