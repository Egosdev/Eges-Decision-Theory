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

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var calc = new UncertaintyDecision();
            Console.WriteLine("Pessimistic (maximin): " + calc.FindMin(matrix).Max().ToString());
            Console.WriteLine("Optimistic (maximax): " + calc.FindMax(matrix).Max().ToString());
            Console.WriteLine("Realism (Hurwicz): " + calc.RealismHurwicz(matrix, 0.3f).Max().ToString());
            Console.WriteLine("Savage (minimax): " + calc.Savage(matrix).ToString());
            Console.WriteLine("Equal Likelihood (Laplace) : " + calc.EqualLikelihood(matrix).Max().ToString());
        }
    }
}