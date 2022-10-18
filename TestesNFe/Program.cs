using System;
using System.Windows.Forms;

namespace TestesNFe
{
    static class Namespace
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTestesNFe());
        }
    }
}
