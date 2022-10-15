using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDolgozo
{
    internal static class Program
    {
        public static FormNyito formNyito = null; //a buildelést el kell indítani
        public static FormDolgozo formDolgozo = null;
        public static Adatbazis adatbazis = new Adatbazis();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formNyito = new FormNyito();
            //formDolgozo = new FormDolgozo();
            Application.Run(formNyito);
        }
    }
}
