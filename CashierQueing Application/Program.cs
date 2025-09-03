namespace CashierQueing_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();

            // Show cashier window first
            cashierWindow.Show();

            Application.Run(new Form1());
        }
    }
}