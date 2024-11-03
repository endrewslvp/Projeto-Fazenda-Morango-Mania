using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over {
    public partial class ControleRh : Form {

        private string nomeUsuario;
        private int index;
        public ControleRh(string nomeUsuario,int index=1) {

            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
        }

        private void iconPerfil_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario,index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }

        private void labelNomeUsuario_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario,index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }

        private void voltarProdutos_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {

        }
    }
}
