using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poljoprivredno_gazdinstvo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form_Usevi_Zivotinje());
            //Application.Run(new Forme.Form_Start());
            //Application.Run(new Forme.Form_Traktor());
            Application.Run(new Forme.Form_Zivotinje());
        }
    }
}
