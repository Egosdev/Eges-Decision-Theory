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
            calc.OptimisticApproach();
            calc.PessimisticApproach();
        }
    }
}