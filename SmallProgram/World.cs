using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProgram
{
    public class World
    {
        private char[,] worldTable;
        private readonly int maxWidth;
        private readonly int maxHeight;
        private readonly string horizontalLine = "";

        public World(int width, int height)
        {
            worldTable = new char[width, height];
            maxWidth = width;
            maxHeight = height;
            for (int i = 0; i < width+2; i++)
            {
                horizontalLine += "-";
            }
        }
    }
}
