using System.Numerics;

namespace Archimedes
{
    public class YoungTableau<T> where T : INumber<T>
    {
        private T [] _x;

        private int _m;
        private int _n;

        private int [] _itemsInRow;

        public YoungTableau (int m, int n, T notValueMinimum)
        {
            _x = new T [m * n];

            _x.Fill (notValueMinimum);

            _m = m;
            _n = n;

            _itemsInRow = new int [_m];
                        
            _itemsInRow.Fill (0);
        }

        public void Insert (T newItem)
        {
            int i = _m - 1;
            int j = _n - _itemsInRow [i];

            int xi = i * _n + j - 1;

            while (j < _n)
            {
                _x [xi] = _x [++xi];
                j++;
            }

            _x [xi] = newItem;
            j--;

            while ((newItem < _x [xi - 1]) || (newItem < _x [xi - _n]))
            {
                if (_x [xi - 1] > _x [xi - _n])
                {
                    _x.Swap (xi, xi - 1);
                    xi--;
                }

                else
                {
                    _x.Swap (xi, xi - _n);
                    xi -= _n;
                }
            }
        }
    }
}