using System;
using System.Collections.Generic;

namespace GameFramework.Board
{
    class Board
    {
        private int width { get; set; }
        private int height { get; set; }
        private Tile[,] tiles;
        
        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
            InitializeBoard();
            Console.WriteLine("The size of the board is: {0}", tiles.Length);
            Console.ReadKey();
        }

        private void InitializeBoard()
        {
            tiles = new Tile[width, height];
            
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    tiles[i,j] = new Tile();
                }
            }
        }

        public Tile getTile(int x, int y)
        {
            return tiles[x, y];
        }

        public void addUnit (Unit unit, int x, int y)
        {
            Tile tile = getTile(x, y);
            tile.addUnit(unit);
        }

        public void removeUnit (Unit unit, int x, int y)
        {
            Tile tile = getTile(x, y);
            tile.removeUnit(unit);
        }

        public void removeUnits(int x, int y)
        {
            Tile tile = getTile(x, y);
            tile.removeUnits();
        }

        public LinkedList<Unit> getUnits(int x, int y)
        {
            return getTile(x, y).getUnits();
        }
    }
}
