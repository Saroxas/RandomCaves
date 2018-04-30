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
        public int AmountOfRooms { get; set; }

        public int MinimalRoomSize;

        #region Constructors
        public MapGenerator(int mapWidth, int mapHeight, int percentAreWalls)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.PercentAreWalls = percentAreWalls;
            this.Iteration = 0;
            this.MinIterations = 4;
            this.NumWallsWhenWall = 4;
            this.NumWallsWhenEmpty = 5;
            this.AmountOfRooms = 0;

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
            this.AmountOfRooms = 0;
        }
        public MapGenerator(int mapWidth, int mapHeight, int percentAreWalls, int minIterations, int numWallsWhenWall, int numWallsWhenEmpty, int minimalRoomSize)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.PercentAreWalls = percentAreWalls;
            this.Iteration = 0;
            this.MinIterations = minIterations;
            this.NumWallsWhenWall = numWallsWhenWall;
            this.NumWallsWhenEmpty = numWallsWhenEmpty;
            this.AmountOfRooms = 0;
            this.MinimalRoomSize = minimalRoomSize;

            RandomFillMap();
        }
        #endregion
        
        #region Mapgeneration and Iteration
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

        public bool IsOutOfBounds(int x, int y)
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

        public bool IsInMapRange(int x, int y)
        {
            return x >= 0 && x < MapWidth && y >= 0 && y < MapHeight;
        }

        private int RandomPercent(int percent)
        {
            if (percent >= rand.Next(1, 101))
            {
                return 1;
            }
            return 0;
        }
        #endregion

        #region Room stuff
        public List<Room> GetRooms(int tileType)
        {
            List<Room> rooms = new List<Room>();
            int[,] mapFlags = new int[MapWidth, MapHeight];

            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if (mapFlags[x, y] == 0 && Map[x, y] == tileType)
                    {
                        List<Coord> roomTiles = GenerateRoomTiles(x, y);
                        Room newRoom = new Room(roomTiles, Map);
                        rooms.Add(newRoom);

                        foreach (Coord tile in roomTiles)
                        {
                            mapFlags[tile.tileX, tile.tileY] = 1;
                        }
                    }
                }
            }

            return rooms;
        }

        public List<Coord> GenerateRoomTiles(int startX, int startY)
        {
            List<Coord> tiles = new List<Coord>();
            int[,] mapFlags = new int[MapWidth, MapHeight];
            int tileType = Map[startX, startY];

            Queue<Coord> queue = new Queue<Coord>();
            queue.Enqueue(new Coord(startX, startY));
            mapFlags[startX, startY] = 1;

            while (queue.Count > 0)
            {
                Coord tile = queue.Dequeue();
                tiles.Add(tile);

                for (int x = tile.tileX - 1; x <= tile.tileX + 1; x++)
                {
                    for (int y = tile.tileY - 1; y <= tile.tileY + 1; y++)
                    {
                        if (IsInMapRange(x, y) && (y == tile.tileY || x == tile.tileX))
                        {
                            if (mapFlags[x, y] == 0 && Map[x, y] == tileType)
                            {
                                mapFlags[x, y] = 1;
                                queue.Enqueue(new Coord(x, y));
                            }
                        }
                    }
                }
            }

            return tiles;
        }

        public void removeSmallRooms(List<Room> allRooms)
        {
            foreach (Room room in allRooms)
            {
                if (room.tiles.Count < MinimalRoomSize)
                {
                    foreach (Coord tile in room.tiles)
                    {
                        Map[tile.tileX, tile.tileY] = 1;
                    }
                }
            }
        }

        public void ConnectClosestRooms(List<Room> allRooms)
        {
            int bestDistance = 0;
            Coord bestTileA = new Coord();
            Coord bestTileB = new Coord();
            Room bestRoomA = new Room();
            Room bestRoomB = new Room();
            bool possibleConnectionFound = false;

            foreach (Room roomA in allRooms)
            {
                possibleConnectionFound = false;

                foreach (Room roomB in allRooms)
                {
                    if (roomA.Equals(roomB))
                    {
                        continue;
                    }

                    if (roomA.IsConnected(roomB))
                    {
                        possibleConnectionFound = false;
                        break;
                    }

                    for (int roomAEdgeIndex = 0; roomAEdgeIndex < roomA.edgeTiles.Count; roomAEdgeIndex++)
                    {
                        for (int roomBEdgeIndex = 0; roomBEdgeIndex < roomB.edgeTiles.Count; roomBEdgeIndex++)
                        {

                            Coord tileA = roomA.edgeTiles[roomAEdgeIndex];
                            Coord tileB = roomB.edgeTiles[roomBEdgeIndex];

                            int distanceBetweenRooms = (int)(Math.Pow(tileA.tileX - tileB.tileX, 2) + Math.Pow(tileA.tileY - tileB.tileY, 2));

                            if (distanceBetweenRooms < bestDistance || !possibleConnectionFound)
                            {
                                bestDistance = distanceBetweenRooms;
                                possibleConnectionFound = true;
                                bestTileA = tileA;
                                bestTileB = tileB;
                                bestRoomA = roomA;
                                bestRoomB = roomB;
                            }
                        }
                    }
                }

                if (possibleConnectionFound)
                {
                    CreatePassage(bestRoomA, bestRoomB, bestTileA, bestTileB);
                }

            }
        }

        public Room FindClosestTileRoom(List<Room> allRooms, Room roomA)
        {
            if(allRooms.Count <= 1)
            {
                return roomA;
            }
            else
            {
                foreach(Room roomB in allRooms)
                {

                }
            }
            return roomA;
        }

        public void CreatePassage(Room roomA, Room roomB, Coord tileA, Coord tileB)
        {
            Room.ConnectRooms(roomA, roomB);
            Coord excavatorPosition = tileA;
            int xDistance = tileA.tileX - tileB.tileX;
            int yDistance = tileA.tileY - tileB.tileY;
            int xDistanceAbs = Math.Abs(xDistance);
            int yDistanceAbs = Math.Abs(yDistance);

            //passageSize(?)
            if((roomA.tiles.Count > 0) || (roomB.tiles.Count > 20))
            {
                Map[excavatorPosition.tileX, excavatorPosition.tileY] = 0; //initial excavation because we start from the outer edge (wall) of the room 

                while(excavatorPosition.Equals(tileB) == false)
                {
                    if(xDistanceAbs > yDistanceAbs)
                    {
                        if(xDistance > 0) //distance is positive so tileB is to the west
                        {
                            //destructoid method
                            excavatorPosition.tileX = excavatorPosition.tileX - 1;
                            Map[excavatorPosition.tileX, excavatorPosition.tileY] = 0;
                            xDistance--;
                            xDistanceAbs--;
                        }
                        else //distance is negative so tileB is to the east
                        {
                            excavatorPosition.tileX = excavatorPosition.tileX + 1;
                            Map[excavatorPosition.tileX, excavatorPosition.tileY] = 0;
                            xDistance++;
                            xDistanceAbs--;
                        }
                    }
                    else
                    {
                        if(yDistance > 0) //distance is positive so tileB is to the north
                        {
                            excavatorPosition.tileY = excavatorPosition.tileY - 1;
                            Map[excavatorPosition.tileX, excavatorPosition.tileY] = 0;
                            yDistance--;
                            yDistanceAbs--;
                        }
                        else //distance is negative so tileB is to the south
                        {
                            excavatorPosition.tileY = excavatorPosition.tileY + 1;
                            Map[excavatorPosition.tileX, excavatorPosition.tileY] = 0;
                            yDistance++;
                            yDistanceAbs--;
                        }
                    }

                }
            }
            else
            {
                //
            }

        }

        #endregion


    }


    public struct Coord
    {
        public int tileX;
        public int tileY;
        public Coord(int x, int y)
        {
            tileX = x;
            tileY = y;
        }
    }
}
