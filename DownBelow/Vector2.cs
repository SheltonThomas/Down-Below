using System;
using System.Collections.Generic;
using System.Text;

namespace DownBelow
{
    class Vector2
    {
        public int x, y;
        public Vector2(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public static bool operator ==(Vector2 vector1, Vector2 vector2)
        {
            if (vector1.x == vector2.x && vector1.y == vector2.y)
                return true;
            return false;
        }

        public static bool operator !=(Vector2 vector1, Vector2 vector2)
        {
            if (vector1.x == vector2.x && vector1.y == vector2.y)
                return false;
            return true;
        }

        public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.x + vector2.x, vector1.y + vector2.y);
        }

        public static Vector2 operator -(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.x - vector2.x, vector1.y - vector2.y);
        }
    }
}
