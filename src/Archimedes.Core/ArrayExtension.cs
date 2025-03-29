namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует 1-мерный массив sourceArray в 2-мерный массив destinationArray.
        /// </summary>
        /// <remarks>Длина 1-мерной массива sourceArray и полная длина 2-мерного массива destinationArray должны быть равны; в 
        /// противном случае корректная работа метода не гарантируется.</remarks>
        public static void CopyTo<T> (this T [] sourceArray, T [,] destinationArray)
        {
            int height   = destinationArray.GetLength (0);
            int width    = destinationArray.GetLength (1);
            int iterator = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destinationArray [i, j] = sourceArray [iterator++];
                }
            }
        }

        /// <summary>
        /// Копирует 2-мерный массив sourceArray в 2-мерный массив destinationArray.
        /// </summary>
        /// <remarks>Размеры массива sourceArray и размеры массива destinationArray должны быть равны; в противном случае корректная 
        /// работа метода не гарантируется.</remarks>
        public static void CopyTo<T> (this T [,] sourceArray, T [,] destinationArray)
        {
            int height = destinationArray.GetLength (0);
            int width  = destinationArray.GetLength (1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    destinationArray [i, j] = sourceArray [i, j];
                }
            }
        }
    }
}