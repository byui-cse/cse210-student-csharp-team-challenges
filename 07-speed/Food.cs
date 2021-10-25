using System;

namespace _07_snake
{
    // TODO: Define the Food class here.
    public class Food : Actor
    {
        private int _food;
        public Food()
        {
            Random rnd = new Random();
            _position = new Point(rnd.Next(0,595),rnd.Next(0,395));
            _velocity = new Point(rnd.Next(0,595),rnd.Next(0,395));
        }

        public int GetPoints()
        {
            return 1;
        }

        public void Reset()
        {
            MoveNext();
        }

    }
}