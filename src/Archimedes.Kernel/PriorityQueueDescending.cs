using System.Numerics;

namespace Archimedes
{
    public class PriorityQueueDescending<TPriority, TItem> : List<KeyValuePair<TPriority, TItem>> where TPriority : INumber<TPriority>
    {
        public KeyValuePair<TPriority, TItem> GetMaximum ()
        {
            return this [0];
        }

        public KeyValuePair<TPriority, TItem> ExtractMaximum ()
        {
            if (Count > 1)
            {
                KeyValuePair<TPriority, TItem> maximum = this [0];

                this [0] = this [Count - 1];
                RemoveAt (Count - 1);

                return maximum;
            }

            else throw new NotImplementedException ();
        }
    }
}