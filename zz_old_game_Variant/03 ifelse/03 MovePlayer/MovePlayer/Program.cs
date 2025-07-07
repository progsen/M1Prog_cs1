namespace MovePlayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
      

        static bool IsRunning = true;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            form.FormClosing += Form_FormClosing;
            form.Show();

            DateTime dateTime = DateTime.Now;
            float frametime = 1;
            while (IsRunning)
            {
                form.DoLogic(frametime);
                form.Invalidate();
                Application.DoEvents();


                DateTime next = DateTime.Now;
                double totalMilliseconds = next.Subtract(dateTime).TotalMilliseconds;
                if (totalMilliseconds == 0)
                {
                    totalMilliseconds = 1;
                }
                frametime = (float)totalMilliseconds / 1000.0f;
                dateTime = next;

            }

            form.Close();
            form.Dispose();
        }

        private static void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsRunning = false;
        }
    }
}