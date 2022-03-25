using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework
{
    public class World
    {
        public static int MaxX { get => MaxX; set => MaxX = value; }
        public static int MaxY { get => MaxY; set => MaxY = value; }

        private object[,] worldCoordinateTable = new object[MaxX,MaxY];

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;

        }
    }
}
