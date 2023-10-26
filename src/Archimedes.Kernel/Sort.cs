namespace Archimedes
{
    public static class Sort
    {
        public static int PartitionRandomized (this int [] array, int begin, int end, Randomizer random)
        {
            int randomIndex = random.Next (begin, end);

            array.Swap (randomIndex, end);

            int x = array [end];

            int partitioner = begin - 1;

            for (int j = begin; j < end; j++)
            {
                if (array [j] < x)
                {
                    partitioner++;
                    array.Swap (partitioner, j);
                }
            }

            partitioner++;
            array.Swap (partitioner, end);

            return partitioner;
        }
    }
}