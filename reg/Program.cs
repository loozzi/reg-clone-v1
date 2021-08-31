using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            string k = "";
            for(int i = 0; i < args.Length; i++)
            {
                k += args[i];
            }
            k = k.Replace("a", "z");
            k = k.Replace("c", "m");
            k = k.Replace("j", "k");
            if (k == "zsdfkzoskfokzskldfkiozweklksdkfiozklskdzsdkklkizsdkk")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainGui());
            }
        }
    }
}
