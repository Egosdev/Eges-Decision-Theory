using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgesDecisionTool
{
    public class UncertaintyDecision
    {
        protected int[] FindMin(int[,] matrix) //kötümser (maximin) temeli
        {
            int[] minValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                minValuesOfEachRow[i] = GetRow(matrix, i).Min();
                //Console.WriteLine(GetRow(matrix, i).Min());

            }
            return minValuesOfEachRow;
        }

        protected int[] FindMax(int[,] matrix) //iyimser (maximax) temeli
        {
            int[] maxValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                maxValuesOfEachRow[i] = GetRow(matrix, i).Max();
                //Console.WriteLine(GetRow(matrix, i).Max());
            }
            return maxValuesOfEachRow;
        }

        protected float[] RealismHurwicz(int[,] matrix, float alpha) //0 <= x <= 1
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

        protected int[,] ConvertLossMatrix(int[,] matrix) //minimax temeli
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

        protected float[] EqualLikelihood(int[,] matrix, int colCount) //laplace
        {
            float[] expectedValuesOfEachRow = new float[matrix.GetLength(0)];
            float n = colCount-1; //n = sütun sayısı

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                expectedValuesOfEachRow[i] = (1 / n) * GetRow(matrix, i).Sum();
                //Console.WriteLine(expectedValuesOfEachRow[i]);
            }
            return expectedValuesOfEachRow;
        }

        protected int[] GetRow(int[,] matrix, int whichRow) // satır uzunluğunu bulmak için sütun sayısına baktım.
        {
            int[] vector = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                vector[i] = matrix[whichRow, i];
            }
            return vector;
        }

        protected int[] GetCol(int[,] matrix, int whichCol)
        {
            int[] vector = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                vector[i] = matrix[i, whichCol];
            }
            return vector;
        }

        public void Example(int[,] matrix)
        {
            Console.WriteLine("Pessimistic (maximin): " + FindMin(matrix).Max().ToString());
            Console.WriteLine("Optimistic (maximax): " + FindMax(matrix).Max().ToString());
            Console.WriteLine("Realism (Hurwicz): " + RealismHurwicz(matrix, 0.6f).Max().ToString());
            Console.WriteLine("Savage (minimax): " + FindMax(ConvertLossMatrix(matrix)).Min().ToString());
            Console.WriteLine("Equal Likelihood (Laplace) : " + EqualLikelihood(matrix,5).Max().ToString());
        }
    }
}
