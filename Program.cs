using System;
using System.Windows.Forms;

namespace MetranTest
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            State.InitState(form1);
            Application.Run(form1);
        }
    }
}
