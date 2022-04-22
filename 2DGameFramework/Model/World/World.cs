using System.Reflection;
using System.Text;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;
using _2DGameFramework.State;

namespace _2DGameFramework.Model.World
{
    public class World
    {
        private char[,] worldTable;
        private readonly int maxWidth;
        private readonly int maxHeight;
        private readonly string horizontalLine = "";
        private readonly object[,] entities;

        /// <summary>
        /// Create a 2D world.
        /// </summary>
        /// <param name="width">With of the 2D world.</param>
        /// <param name="height">Height of the 2D world.</param>
        public World(int width, int height)
        {
            worldTable = new char[width, height];
            maxWidth = width;
            maxHeight = height;
            for (int i = 0; i < width + 2; i++)
            {
                horizontalLine += "-";
            }
        }

        /// <summary>
        /// Create a 2D world and give it a list of objects to fill it.
        /// </summary>
        /// <param name="width">With of the 2D world.</param>
        /// <param name="height">Height of the 2D world.</param>
        /// <param name="theEntities">A two dimensionel object array with a coordinate for every field of the world.</param>
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

        /// <summary>
        /// Print the playground in the Console.
        /// </summary>
        /// <param name="gameName">Name of the Game World.</param>
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
            if (entities[row, col] != null)
            {
                Console.WriteLine("o");
            }
            else
            {
                Console.WriteLine(' ');
            }
        }


    }
}
