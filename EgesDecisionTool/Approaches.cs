using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgesDecisionTool
{
    internal class Approaches : UncertaintyDecision
    {
        private void CreateApproachColumn<T>(string colName, string header, DataGridView dgw, T[] resultArray)
        {
            dgw.Columns.Add(colName, header);
            dgw.Columns[colName].DefaultCellStyle.BackColor = Color.LightGray;
            dgw.Columns[colName].DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgw.Columns[colName].ReadOnly = true;
            for (int i = 0; i < dgw.RowCount; i++)
            {
                dgw.Rows[i].Cells[dgw.ColumnCount - 1].Value = resultArray[i];
            }
        }

        public void PessimisticApproach(int[,] table, DataGridView dgw)
        {
            int[] minArray = FindMin(table);
            CreateApproachColumn("maximin", "Kötümserlik", dgw, minArray);

            Console.WriteLine("Pessimistic (maximin): " + minArray.Max().ToString());
            dgw.Rows[Array.IndexOf(minArray, minArray.Max())].Cells[dgw.ColumnCount - 1].Style.BackColor = Color.LightGreen;
        }
        public void OptimisticApproach(int[,] table, DataGridView dgw)
        {
            int[] maxArray = FindMax(table);
            CreateApproachColumn("maximax", "İyimserlik", dgw, maxArray);

            dgw.Rows[Array.IndexOf(maxArray, maxArray.Max())].Cells[dgw.ColumnCount - 1].Style.BackColor = Color.LightGreen;
            Console.WriteLine("Optimistic (maximax): " + maxArray.Max().ToString());
        }
        public void RealismApproach(int[,] table, DataGridView dgw, float alpha)
        {
            float[] array = RealismHurwicz(table, alpha);
            CreateApproachColumn("realism", "Hurwicz " + alpha, dgw, array);

            dgw.Rows[Array.IndexOf(array, array.Max())].Cells[dgw.ColumnCount - 1].Style.BackColor = Color.LightGreen;
            Console.WriteLine("Realism (Hurwicz): " + RealismHurwicz(table, alpha).Max().ToString());
        }
        public void SavageApproach(int[,] table, DataGridView dgw)
        {
            int[] maxArray = FindMax(ConvertLossMatrix(table));
            CreateApproachColumn("minimax", "Pişmanlık", dgw, maxArray);

            dgw.Rows[Array.IndexOf(maxArray, maxArray.Min())].Cells[dgw.ColumnCount - 1].Style.BackColor = Color.LightGreen;
            Console.WriteLine("Savage (minimax): " + FindMax(ConvertLossMatrix(table)).Min().ToString());
        }
        public void EqualLikelihood(int[,] table, DataGridView dgw, int colCount)
        {
            float[] array = EqualLikelihood(table, colCount);
            CreateApproachColumn("laplace", "Eşit Olasılık", dgw, array);

            dgw.Rows[Array.IndexOf(array, array.Max())].Cells[dgw.ColumnCount - 1].Style.BackColor = Color.LightGreen;
            Console.WriteLine("Equal Likelihood (Laplace) : " + EqualLikelihood(table, colCount).Max().ToString());
        }
    }
}
