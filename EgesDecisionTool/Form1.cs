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

        public int[,] matrix3 = new int[3, 3];

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(3);
            dataGridView1.Columns.Add("asd","s1");
            dataGridView1.Columns.Add("asd","s2");
            dataGridView1.Columns.Add("asd","s3");
            DataGridViewSettings(dataGridView1);
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
            //Console.WriteLine("Pessimistic (maximin): " + calc.FindMin(matrix2).Max().ToString());
            //Console.WriteLine("Optimistic (maximax): " + calc.FindMax(matrix2).Max().ToString());
            //Console.WriteLine("Realism (Hurwicz): " + calc.RealismHurwicz(matrix2, 0.6f).Max().ToString());
            //Console.WriteLine("Savage (minimax): " + calc.Savage(matrix2).ToString());
            //Console.WriteLine("Equal Likelihood (Laplace) : " + calc.EqualLikelihood(matrix2).Max().ToString());
        }

        private void DataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new UncertaintyDecision();

            FillMatrix();

            Console.WriteLine("Pessimistic (maximin): " + calc.FindMin(matrix3).Max().ToString());
            Console.WriteLine("Optimistic (maximax): " + calc.FindMax(matrix3).Max().ToString());
            Console.WriteLine("Realism (Hurwicz): " + calc.RealismHurwicz(matrix3, 0.6f).Max().ToString());
            Console.WriteLine("Savage (minimax): " + calc.Savage(matrix3).ToString());
            Console.WriteLine("Equal Likelihood (Laplace) : " + calc.EqualLikelihood(matrix3).Max().ToString());
        }

        private void FillMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    //Console.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    matrix3[i, j-1] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}