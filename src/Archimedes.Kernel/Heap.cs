using System.Numerics;

namespace Archimedes
{
    public abstract class Heap<T> where T : INumber<T>
    {
        protected List<T> _a;

        public int HeapSize
        {
            get => _a.Count;
        }

        protected Heap ()
        {
            _a = new List<T> ();
        }

        protected Heap (T onlyItem) : this ()
        {
            _a.Add (onlyItem);
        }

        protected Heap (params T [] array) : this ()
        {
            throw new NotImplementedException ();
        }

        protected Heap (List<T> list) : this ()
        {
            throw new NotImplementedException ();
        }

        protected abstract void Heapify (int subtreeRoot);

        protected abstract void BuildHeap (params T [] array);

        protected abstract void BuildHeap (List<T> list);

        protected T GetRoot ()
        {
            throw new NotImplementedException ();
        }

        protected T PopRoot ()
        {
            throw new NotImplementedException ();
        }

        protected abstract void ChangeItem (int index, T newValue);

        protected abstract void InsertItem (T insertedValue);

        public int GetFirstLeaf ()
        {
            throw new NotImplementedException ();
        }

        public int GetLeftChild (int index)
        {
            throw new NotImplementedException ();
        }

        public int GetRightChild (int index)
        {
            throw new NotImplementedException ();
        }

        public int Parent (int index)
        {
            throw new NotImplementedException ();
        }

        public int HowManyChildren (int index)
        {
            throw new NotImplementedException ();
        }
    }
}