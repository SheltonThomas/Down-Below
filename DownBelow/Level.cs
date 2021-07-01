using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    public enum TileType
    {
        EmptySpace = ' ',
        WallHorizontal = '─',
        WallVerticle = '│',
        TopLeftCorner = '┌',
        TopRightCorner = '┐',
        LeftMiddleCorner = '├',
        RightMiddleCorner = '┤',
        BottomLeftCorner = '└',
        BottomRightCorner = '┘',
        MiddleMiddlePiece = '┼',
        Player = 'O',
        BridgeVerticle = '║',
        BridgeHorizontal = '═',
        Enemy = 'X'
    }

    class Level
    {
        public static List<TileType> collidableTiles;
        private List<GameObject> _mapObjects;
        private string _mapToDraw;
        private int _mapSize;
        public Level NextLevel { get; set; }
        public Level PreviousLevel { get; set; }

        public Level(int mapXYSize)
        {
            collidableTiles = new List<TileType>();
            collidableTiles.Add(TileType.WallHorizontal);
            collidableTiles.Add(TileType.WallVerticle);
            collidableTiles.Add(TileType.TopLeftCorner);
            collidableTiles.Add(TileType.TopRightCorner);
            collidableTiles.Add(TileType.LeftMiddleCorner);
            collidableTiles.Add(TileType.RightMiddleCorner);
            collidableTiles.Add(TileType.BottomLeftCorner);
            collidableTiles.Add(TileType.BottomRightCorner);
            collidableTiles.Add(TileType.MiddleMiddlePiece);


            _mapObjects = new List<GameObject>();
            _mapSize = mapXYSize;
            _mapToDraw = "";

            //Add Tasks
        }

        public void Start()
        {
            UpdateMap();

            foreach(GameObject mapObject in _mapObjects)
            {
                if (mapObject.Started || mapObject == null)
                    continue;

                mapObject.Start();
                mapObject.Started = true;
            }
        }

        public void Update()
        {
            foreach(GameObject mapObject in _mapObjects)
            {
                if (mapObject == null)
                    continue;

                mapObject.Update();
            }
        }

        public void UpdateMap()
        {
            //Create an array used to store the order of the map
            GameObject[] mapOrder = new GameObject[_mapSize * _mapSize];
            foreach(GameObject mapObject in _mapObjects)
            {
                //Gets the current iterator's object's position.
                Vector2 objectPosition = mapObject.GetPosition();
                //Gets the current object in the same position as the iterator's object in all the map objects.
                GameObject currentMapObject = _mapObjects[objectPosition.y * _mapSize + objectPosition.x];

                //If the object in the current mapOrder index is null then set it to the current item.
                if (mapOrder[objectPosition.y * _mapSize + objectPosition.x] == null)
                    mapOrder[objectPosition.y * _mapSize + objectPosition.x] = mapObject;

                //If the object in the current mapOrder index isn't null,
                //Then set it to whichever gameObject's priority is higher.
                else if (mapObject.Priority < currentMapObject.Priority)
                    mapOrder[objectPosition.y * _mapSize + objectPosition.x] = mapObject;
            }

            //Create a string builder to build the map.
            StringBuilder mapBuilder = new StringBuilder(_mapSize * _mapSize);
            foreach(GameObject mapObject in mapOrder)
            {
                Vector2 objectPosition = mapObject.GetPosition();
                mapBuilder.Insert(objectPosition.y * _mapSize + objectPosition.x, (char)mapObject.GetTileType());
            }

            //Add end lines to space out the different lines of the map.
            int endLinePlacement = _mapSize * _mapSize;
            while(endLinePlacement > 0)
            {
                mapBuilder.Insert(endLinePlacement, "\n");
                endLinePlacement -= _mapSize;
            }

            //Set map to draw to the string that was built.
            _mapToDraw = mapBuilder.ToString();
        }

        public void CheckCollision()
        {
            //Implement after Player.cs is added
        }

        public bool IsLevelComplete()
        {
            //Implement after Tasks.cs is added
            return false;
        }

        public string GetMapToDraw()
        {
            return _mapToDraw;
        }
    }
}
