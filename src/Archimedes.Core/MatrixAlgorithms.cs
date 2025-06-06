﻿namespace Archimedes
{
    public static class MatrixAlgorithms
    {
        /// <summary>
        /// Стандартный O (n^3) алгоритм умножения матриц a и b: c = a x b.
        /// </summary>
        /// <param name="c">Двумерный массив, в который записывается результат умножения.</param>
        /// <param name="height">Высота матрицы a и результирующей матрицы.</param>
        /// <param name="commonSize">Ширина матрицы a = высота матрицы b.</param>
        /// <param name="width">Ширина матрицы b и результирующей матрицы.</param>
        /// <returns>Возвращает матрицу размером height  width.</returns>
        /// <remarks>В методе не производится проверка на консистентность размеров матриц a, b и c. В нём осуществляются только 
        /// вычисления. В случае несогласованности размеров матриц корректная работа метода не гарантируется.</remarks>
        public static void StandardMultiplication (double [,] a, double [,] b, double [,] c, int height, int commonSize, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double sum = 0.0;

                    for (int k = 0; k < commonSize; k++)
                    {
                        sum += a [i, k] * b [k, j];
                    }

                    c [i, j] = sum;
                }
            }
        }
    }
}