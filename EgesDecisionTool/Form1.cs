namespace EgesDecisionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var calc = new Approaches();
            Console.WriteLine("Pessimistic (maximin): " + calc.PessimisticApproach().Max().ToString());
            Console.WriteLine("Optimistic (maximax): " + calc.OptimisticApproach().Max().ToString());
            Console.WriteLine("Realism (Hurwicz): " + calc.RealismHurwiczApproach(0.3f).Max().ToString());
        }
    }
}