using System.Numerics;

namespace Archimedes
{
    public static class Heap
    {
        /// <summary>
        /// Строит невозрастающую бинарную пирамиду на поддереве из массива <paramref name="array"/> с корнем в индексе 
        /// <paramref name="subtreeRoot"/>.
        /// </summary>
        public static void MaxHeapify<T> (this T [] array, int subtreeRoot) where T : INumber<T>
        {
            int i         = subtreeRoot;
            int firstLeaf = array.Length / 2;

            while (i < firstLeaf)
            {
                int leftChild  = (i << 1) + 1;
                int largest    = (array [leftChild] > array [i]) ? leftChild : i;
                int rightChild = leftChild + 1;

                if ((rightChild < array.Length) && (array [rightChild] > array [i])) largest = rightChild;

                if (largest > i)
                {
                    array.Swap (i, largest);

                    i = largest;
                }

                else break;
            }
        }
    }
}