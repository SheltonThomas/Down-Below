using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    public enum KeyPressed
    {
        Default,
        Up,
        Down,
        Left,
        Right,
        Select,
        Back,
        Exit,
        Invalid
    }
    class Player : GameObject
    {
        //Add Inventory when class is made
        public Player(int x, int y, bool hasCollision) : base(x, y, hasCollision, 0, TileType.Player)
        {

        }
    }
}
