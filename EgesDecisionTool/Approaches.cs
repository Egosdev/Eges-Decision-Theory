using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgesDecisionTool
{
    internal class Approaches : UncertaintyDecision
    {
        public void PessimisticApproach(int[,] table, DataGridView dgw)
        {
            dgw.Columns.Add("maximin", "Kötümserlik");
            int[] minArray = FindMin(table);
            for (int i = 0; i < dgw.RowCount; i++)
            {
                dgw.Rows[i].Cells[dgw.ColumnCount - 1].Value = minArray[i];
            }
            Console.WriteLine("Pessimistic (maximin): " + FindMin(table).Max().ToString());
        }
    }
}
