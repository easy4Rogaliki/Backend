using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Data.Classes
{
    internal class MapGenerator
    {
        static int x;
        static int y;

        //List<List<int>> coordsArray = new List<int>();

        static int[,] coordsArray = new int[x, y];

        public static int Generate(int x, int y)
        {
            Random random = new Random();
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                }
            }

        }
    }
}
