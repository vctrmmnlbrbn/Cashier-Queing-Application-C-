namespace CashierQueing_Application
{
    public partial class Form1 : Form
    {
        private CashierWindowQueueForm cashierWindow;
        private CashierClass cashier;
        public Form1()
        {
            InitializeComponent();

            cashier = new CashierClass();
            cashierWindow = new CashierWindowQueueForm();
        }

        private void Cashier_Click_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cashierWindow.Show(); ;
        }
    }
}
