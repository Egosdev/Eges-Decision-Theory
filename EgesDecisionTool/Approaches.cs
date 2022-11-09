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

        public void PessimisticApproach()
        {
            int[] minValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                minValuesOfEachRow[i] = GetRow(matrix, i).Min();
            }
            Console.WriteLine("Pessimistic: " + minValuesOfEachRow.Max().ToString());
        }

        public void OptimisticApproach()
        {
            int[] maxValuesOfEachRow = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                maxValuesOfEachRow[i] = GetRow(matrix, i).Max();
                //Console.WriteLine(GetRow(matrix, i).Max());
            }
            Console.WriteLine("Optimistic: " + maxValuesOfEachRow.Max().ToString());
        }

        public int[] GetRow(int[,] matrix, int whichRow)
        {
            int[] vector = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                vector[i] = matrix[whichRow, i];
            }
            return vector;
        }
    }
}
