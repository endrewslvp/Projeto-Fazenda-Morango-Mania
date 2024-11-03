using over.Views.ModuloControles.ModuloControleVendas.ModuloVendas;
using System;
using System.Windows.Forms;

namespace over {
    internal static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
