using System.Text;

namespace _2DGameFramework.Model.World
{
    public class World
    {
        private char[,] worldTable;
        private readonly int maxWidth;
        private readonly int maxHeight;
        private readonly string horizontalLine = "";
        private readonly object[,] entities;

        public World(int width, int height, object[,] theEntities)
        {
            worldTable = new char[width, height];
            maxWidth = width;
            maxHeight = height;
            entities = theEntities;
            for (int i = 0; i < width + 2; i++)
            {
                horizontalLine += "-";
            }
        }

        public void PrintPlayground(string gameName)
        {
            Console.Clear();
            Console.WriteLine(gameName);
            Console.WriteLine(horizontalLine);
            for (int i = 0; i < maxHeight; i++)
            {
                Console.WriteLine("|");
                PrintRowString(i);
                Console.WriteLine($"|");
            }
            Console.WriteLine(horizontalLine);
        }

        private void PrintRowString(int i)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < maxWidth; j++)
            {
                PrintColRowChar(i, j);
            }
        }

        private void PrintColRowChar(int row, int col)
        {
            //TODO Print the world
        }
    }
}
