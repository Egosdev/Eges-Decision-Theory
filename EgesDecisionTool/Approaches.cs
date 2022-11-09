using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgesDecisionTool
{
    public class Approaches
    {
        public int[,] matrix = new int[3, 3]
        {
            {-15000, 1000, 65000},
            {-12500 ,2700 ,63500},
            {0 ,0 ,0}
        };

        public int[] PessimisticApproach() //kötümser (maximin)
        {
            int[] minValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                minValuesOfEachRow[i] = GetRow(matrix, i).Min();
                //Console.WriteLine(GetRow(matrix, i).Min());

            }
            return minValuesOfEachRow;
        }

        public int[] OptimisticApproach() //iyimser (maximax)
        {
            int[] maxValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                maxValuesOfEachRow[i] = GetRow(matrix, i).Max();
                //Console.WriteLine(GetRow(matrix, i).Max());
            }
            return maxValuesOfEachRow;
        }

        public float[] RealismHurwiczApproach(float alpha) //0 <= x <= 1
        {
            float[] solutionOfEachRow = new float[matrix.GetLength(0)];
            int[] maxValues = OptimisticApproach();
            int[] minValues = PessimisticApproach();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                solutionOfEachRow[i] = (alpha * maxValues[i]) + ((1 - alpha) * minValues[i]);
                //Console.WriteLine(solutionOfEachRow[i]);
            }
            return solutionOfEachRow;
        }

        public void Savage()
        {

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
