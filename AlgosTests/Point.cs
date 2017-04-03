namespace AlgosTests
{
    public class Point
    {
        int _x, _y;

        public Point(int _x, int _y)
        {
            this._x = _x;
            this._y = _y;
        }

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }
    }
}