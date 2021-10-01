using System;

namespace Les3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Room room1 = new Room(2,2);
        }
    }

    class Tile
    {

    }
    class Room
    {
        Tile[][] tileMap;

        public Room( int width, int height)
        {
            tileMap = new Tile [height][];
            for (int i = 0; i < tileMap.Length; i++)
            {
                tileMap[i] = new Tile[width];
                for (int K = 0; K < tileMap[i].Length; K++)
                {
                    tileMap[i][K] = new Tile();
                }
            }
        }
    }
}
