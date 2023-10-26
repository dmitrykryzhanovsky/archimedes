using System;

namespace Archimedes
{
    public class DefaultRandomizer : Randomizer
    {
        private Random _random;

        public DefaultRandomizer ()
        {
            _random = new Random ();
        }

        public override int Next (int minValue, int maxValue)
        {
            return _random.Next (minValue, maxValue);
        }
    }
}