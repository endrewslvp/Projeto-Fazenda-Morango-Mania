using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over.Funcionalidades
{
    public partial class EscurecimentoFundo : Form
    {
        public EscurecimentoFundo(Form form)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            Opacity = 0.5;  // Define o nível de transparência
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Size = form.Size; // O mesmo tamanho da tela atual
            Location = form.Location; // Mesma posição
        }

        private void EscurecimentoFundo_Load(object sender, EventArgs e)
        {

        }
    }
}
