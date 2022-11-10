using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgesDecisionTool
{
    public class UncertaintyDecision
    {
        public int[] FindMin(int[,] matrix) //kötümser (maximin) temeli
        {
            int[] minValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                minValuesOfEachRow[i] = GetRow(matrix, i).Min();
                //Console.WriteLine(GetRow(matrix, i).Min());

            }
            return minValuesOfEachRow;
        }

        public int[] FindMax(int[,] matrix) //iyimser (maximax) temeli
        {
            int[] maxValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                maxValuesOfEachRow[i] = GetRow(matrix, i).Max();
                //Console.WriteLine(GetRow(matrix, i).Max());
            }
            return maxValuesOfEachRow;
        }

        public float[] RealismHurwicz(int[,] matrix, float alpha) //0 <= x <= 1
        {
            float[] solutionOfEachRow = new float[matrix.GetLength(0)];
            int[] maxValues = FindMax(matrix);
            int[] minValues = FindMin(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                solutionOfEachRow[i] = (alpha * maxValues[i]) + ((1 - alpha) * minValues[i]);
                //Console.WriteLine(solutionOfEachRow[i]);
            }
            return solutionOfEachRow;
        }

        public int[,] ConvertLossMatrix(int[,] matrix) //minimax temeli
        {
            int[,] lossMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int maxValue = GetCol(matrix, i).Max();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    lossMatrix[j,i] = maxValue - matrix[j, i];
                }
            }
            return lossMatrix;
        }

        public int Savage(int[,] matrix)
        {
            return FindMax(ConvertLossMatrix(matrix)).Min();
        }

        public float[] EqualLikelihood(int[,] matrix) //laplace
        {
            float[] expectedValuesOfEachRow = new float[matrix.GetLength(0)];
            float n = matrix.GetLength(1); //n = sütun sayısı

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                expectedValuesOfEachRow[i] = (1 / n) * GetRow(matrix, i).Sum();
                //Console.WriteLine(expectedValuesOfEachRow[i]);
            }
            return expectedValuesOfEachRow;
        }

        public int[] GetRow(int[,] matrix, int whichRow) // satır uzunluğunu bulmak için sütun sayısına baktım.
        {
            int[] vector = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                vector[i] = matrix[whichRow, i];
            }
            return vector;
        }

        public int[] GetCol(int[,] matrix, int whichCol)
        {
            int[] vector = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                vector[i] = matrix[i, whichCol];
            }
            return vector;
        }
    }
}
