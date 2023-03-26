using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP02
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Main _Main;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApplicationContext.Open(new Main());
            Application.Run();
        }
        public static int formCount;
        public class MyApplicationContext : ApplicationContext
        {
            static public void Open(Form form)
            {

                form.Closed += OnFormClosed;
                formCount++;
                form.Show();
                form.Focus();
            }

            static public void OnFormClosed(object sender, EventArgs e)
            {
                formCount--;
                if (formCount <= 0)
                {
                    Application.Exit();
                }
            }
        }
    }
}
