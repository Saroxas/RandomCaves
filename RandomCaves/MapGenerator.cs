using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCaves
{
    class MapGenerator
    {
        Random rand = new Random();

        public int[,] Map { get; set; }
        public int MapWidth { get; set; }
        public int MapHeight { get; set; }
        public int PercentAreWalls { get; set; }
        public int Iteration { get; set; }
        public int MinIterations { get; set; }
        public int NumWallsWhenWall { get; set; }
        public int NumWallsWhenEmpty { get; set; }

        public MapGenerator(int mapWidth, int mapHeight, int percentAreWalls)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.PercentAreWalls = percentAreWalls;
            this.Iteration = 0;
            this.MinIterations = 4;
            this.NumWallsWhenWall = 4;
            this.NumWallsWhenEmpty = 5;

            RandomFillMap();
        }

        public MapGenerator(int mapWidth, int mapHeight, int percentAreWalls, int[,] map)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.PercentAreWalls = percentAreWalls;
            this.Map = new int[this.MapWidth, this.MapHeight];
            this.Map = map;
            this.Iteration = 0;
            this.MinIterations = 4;
            this.NumWallsWhenWall = 4;
            this.NumWallsWhenEmpty = 5;
        }
        public MapGenerator(int mapWidth, int mapHeight, int percentAreWalls, int minIterations, int numWallsWhenWall, int numWallsWhenEmpty)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.PercentAreWalls = percentAreWalls;
            this.Iteration = 0;
            this.MinIterations = minIterations;
            this.NumWallsWhenWall = numWallsWhenWall;
            this.NumWallsWhenEmpty = numWallsWhenEmpty;

            RandomFillMap();
        }

        public void RandomFillMap()
        {
            // New, empty map
            Map = new int[MapWidth, MapHeight];

            int mapMiddle = 0; // Temp variable
            for (int column = 0, row = 0; row < MapHeight; row++)
            {
                for (column = 0; column < MapWidth; column++)
                {
                    // If coordinants lie on the the edge of the map (creates a border)
                    if (column == 0)
                    {
                        Map[column, row] = 1;
                    }
                    else if (row == 0)
                    {
                        Map[column, row] = 1;
                    }
                    else if (column == MapWidth - 1)
                    {
                        Map[column, row] = 1;
                    }
                    else if (row == MapHeight - 1)
                    {
                        Map[column, row] = 1;
                    }
                    // Else, fill with a wall a random percent of the time
                    else
                    {
                        mapMiddle = (MapHeight / 2);

                        if (row == mapMiddle)
                        {
                            Map[column, row] = 0;
                        }
                        else
                        {
                            Map[column, row] = RandomPercent(PercentAreWalls);
                        }
                    }
                }
            }
        }

        private int RandomPercent(int percent)
        {
            if (percent >= rand.Next(1, 101))
            {
                return 1;
            }
            return 0;
        }

        public void BlankMap()
        {
            for (int column = 0, row = 0; row < MapHeight; row++)
            {
                for (column = 0; column < MapWidth; column++)
                {
                    Map[column, row] = 0;
                }
            }
        }

        public void MakeCaverns()
        {
            // By initilizing column in the outter loop, its only created ONCE
            for (int column = 0, row = 0; row <= MapHeight - 1; row++)
            {
                for (column = 0; column <= MapWidth - 1; column++)
                {
                    Map[column, row] = PlaceWallLogic(column, row);
                }
            }
        }

        public int PlaceWallLogic(int x, int y)
        {
            int numWalls = GetAdjacentWalls(x, y, 1, 1);


            if (Map[x, y] == 1)
            {
                if (numWalls >= NumWallsWhenWall)
                {
                    return 1;
                }
                if ((Iteration > MinIterations) && (numWalls < 2))
                {
                    return 1;
                }

            }
            else
            {
                if (numWalls >= NumWallsWhenEmpty)
                {
                    return 1;
                }
            }
            return 0;
        }
        public int GetAdjacentWalls(int x, int y, int scopeX, int scopeY)
        {
            int startX = x - scopeX;
            int startY = y - scopeY;
            int endX = x + scopeX;
            int endY = y + scopeY;

            int iX = startX;
            int iY = startY;

            int wallCounter = 0;

            for (iY = startY; iY <= endY; iY++)
            {
                for (iX = startX; iX <= endX; iX++)
                {
                    if (!(iX == x && iY == y))
                    {
                        if (IsWall(iX, iY))
                        {
                            wallCounter += 1;
                        }
                    }
                }
            }
            return wallCounter;
        }

        bool IsWall(int x, int y)
        {
            // Consider out-of-bound a wall
            if (IsOutOfBounds(x, y))
            {
                return true;
            }

            if (Map[x, y] == 1)
            {
                return true;
            }

            if (Map[x, y] == 0)
            {
                return false;
            }
            return false;
        }

        bool IsOutOfBounds(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return true;
            }
            else if (x > MapWidth - 1 || y > MapHeight - 1)
            {
                return true;
            }
            return false;
        }
    }
}
