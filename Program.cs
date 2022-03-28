using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // setup globals
            Globals.AssetSetup();

            // run form
            //List<Player> p = new List<Player>();
            //bool[] options = new bool[4] { true, true, true, true };
            //Application.Run(new Game(p, options));
            Application.Run(new Startup());
        }
    }
}
