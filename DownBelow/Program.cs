using System;

namespace DownBelow
{
    class Program
    {
        static void Main(string[] args)
        {
            Level test = new Level(4);
            test.Start();

            Console.Write(test.GetMapToDraw());
        }
    }
}
