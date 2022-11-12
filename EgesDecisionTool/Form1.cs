namespace EgesDecisionTool
{
    public partial class Form1 : Form
    {
        public int[,] matrix = new int[3, 3]
        {
            {-15000, 1000, 65000},
            {-12500 ,2700 ,63500},
            {0 ,0 ,0}
        };

        public int[,] matrix2 = new int[3, 4]
        {
            {200, 600, -600, 200},
            {0, 200, -200, 200},
            {-160, 400, -300, 200}
        };

        public int[,] matrix3 = new int[99, 99];
        int rowCount; 
        int colCount = 1;

        public Form1()
        {
            InitializeComponent();
            DataGridViewSettings(dgw_uncertainty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var calc = new UncertaintyDecision();
            //Console.WriteLine("Pessimistic (maximin): " + calc.FindMin(matrix).Max().ToString());
            //Console.WriteLine("Optimistic (maximax): " + calc.FindMax(matrix).Max().ToString());
            //Console.WriteLine("Realism (Hurwicz): " + calc.RealismHurwicz(matrix, 0.6f).Max().ToString());
            //Console.WriteLine("Savage (minimax): " + calc.Savage(matrix).ToString());
            //Console.WriteLine("Equal Likelihood (Laplace) : " + calc.EqualLikelihood(matrix).Max().ToString());
            //Console.WriteLine("----");
            calc.Example(matrix2);
        }

        private void DataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns[0].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!cbx_pessimistic.Checked && !cbx_optimistic.Checked && !cbx_realism.Checked && !cbx_savage.Checked && !cbx_equallikelihood.Checked) return;
            if (dgw_uncertainty.ColumnCount <= 2 || dgw_uncertainty.RowCount <= 1) return;

            matrix3 = new int[rowCount, colCount];
            Approaches calc = new Approaches();

            FillMatrix();
            ClearCalculations();
            if (cbx_pessimistic.Checked)
                calc.PessimisticApproach(matrix3, dgw_uncertainty);
            if (cbx_optimistic.Checked)
                calc.OptimisticApproach(matrix3, dgw_uncertainty);
            if (cbx_realism.Checked)
            {
                if (tbx_alpha.Text.Length == 0) return;
                if (tbx_alpha.Text.Length == 1) tbx_alpha.Text = tbx_alpha.Text + "0";
                float value = Convert.ToInt32(tbx_alpha.Text) / 100f;
                calc.RealismApproach(matrix3, dgw_uncertainty, value);
                Console.WriteLine(value);
            }
            if (cbx_savage.Checked)
                calc.SavageApproach(matrix3, dgw_uncertainty);
            if (cbx_equallikelihood.Checked)
                calc.EqualLikelihood(matrix3, dgw_uncertainty, colCount);
        }

        private void FillMatrix()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 1; j < colCount; j++)
                {
                    //Console.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    matrix3[i, j - 1] = Convert.ToInt32(dgw_uncertainty.Rows[i].Cells[j].Value);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_alpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbx_alpha.MaxLength = 2;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_add_alternative_Click(object sender, EventArgs e)
        {
            ClearCalculations();
            rowCount++;
            if (tbx_add_alternative.Text.Length == 0)
                dgw_uncertainty.Rows.Add("a" + (dgw_uncertainty.RowCount + 1));
            else
                dgw_uncertainty.Rows.Add(tbx_add_alternative.Text);
            tbx_add_alternative.Text = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearCalculations();
            colCount++;
            if (tbx_add_natural_state.Text.Length == 0)
                dgw_uncertainty.Columns.Add("s" + (dgw_uncertainty.ColumnCount), "s" + (dgw_uncertainty.ColumnCount));
            else
                dgw_uncertainty.Columns.Add("s" + (dgw_uncertainty.ColumnCount), tbx_add_natural_state.Text);
            tbx_add_natural_state.Text = null;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btn_meatball_device_Click(object sender, EventArgs e)
        {
            PrepareMeatballTable();
            rowCount = 3;
            colCount = 4;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    dgw_uncertainty.Rows[i].Cells[j].Value = matrix[i, j - 1];
                }
            }
        }
        private void ClearCalculations()
        {
            dgw_uncertainty.RowCount = rowCount;
            dgw_uncertainty.ColumnCount = colCount;
        }
        private void ClearAll()
        {
            dgw_uncertainty.Rows.Clear();
            dgw_uncertainty.Columns.Clear();
            dgw_uncertainty.Columns.Add("Alternatives", "Stratejiler");
            dgw_uncertainty.Columns[0].ReadOnly = true;
            rowCount = 0;
            colCount = 1;
        }
        private void PrepareMeatballTable()
        {
            ClearAll();
            for (int i = 0; i < 3; i++)
            {
                dgw_uncertainty.Columns.Add("s" + (dgw_uncertainty.ColumnCount), "s" + (dgw_uncertainty.ColumnCount));
                dgw_uncertainty.Rows.Add("a" + (dgw_uncertainty.RowCount + 1));
            }
        }
    }
}