namespace _0502
{
    static class Global
    {
        public static bool needExit = false;
    }

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
            
            bool createdNew;
            using (var mutex = new System.Threading.Mutex(true, "{Form1}", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    // Програма вже запущена, можна виконати відповідні дії (наприклад, вивести повідомлення)
                    MessageBox.Show("Програма вже запущена!");
                }
            }
        }
    }
}