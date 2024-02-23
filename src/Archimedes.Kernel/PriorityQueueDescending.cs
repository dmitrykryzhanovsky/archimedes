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
            KeyValuePair<TPriority, TItem> maximum = GetMaximum ();

            RemoveAt (0);            

            return maximum;
        }
    }
}