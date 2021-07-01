using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    class GameObject
    {
        protected Vector2 _position;
        protected TileType _tileType;
        protected bool _hasCollision;
        protected ConsoleColor _color;

        public bool Started { get; set; }

        public int Priority { get; set; }

        public GameObject(int x, int y, bool hasCollision, int objectPriority, TileType tileType, ConsoleColor color = ConsoleColor.White)
        {
            _position = new Vector2(x, y);
            _hasCollision = hasCollision;
            Priority = objectPriority;
            _tileType = tileType;
            _color = color;
        }

        public virtual void Start() { }

        public virtual void Update() { }

        public TileType GetTileType()
        {
            return _tileType;
        }

        public ConsoleColor GetColor()
        {
            return _color;
        }

        public void SetPosition(Vector2 newPosition)
        {
            _position = newPosition;
        }

        public void SetPosition(int x, int y)
        {
            _position = new Vector2(x, y);
        }

        public void Move(Vector2 movementDirection)
        {
            _position = _position + movementDirection;
        }

        public Vector2 GetPosition()
        {
            return _position;
        }

        public void SetCollision(bool newCollision)
        {
            _hasCollision = newCollision;
        }

        public bool IsCollidable()
        {
            return _hasCollision;
        }
    }
}
