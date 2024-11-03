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
    public partial class PaineldeControle : Form {

        private string nomeUsuario;
        private int index;

        public PaineldeControle(string nomeUsuario, int index) {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
        }

        private void btnAcessarControleProducao_Click(object sender, EventArgs e)
        {
            ControleProducao producao = new ControleProducao(nomeUsuario,index);
            FormNavigator.OpenForm(this, producao);
        }

        private void btnAcessarControleDeRH_Click(object sender, EventArgs e)
        {
            ControleRh rh = new ControleRh(nomeUsuario, index);
            FormNavigator.OpenForm(this, rh);
        }

        private void btnAcessarControleDeVendas_Click(object sender, EventArgs e)
        {
            ControleVendas vendas = new ControleVendas(nomeUsuario,index);
            FormNavigator.OpenForm(this, vendas);
        }

        private void btnAcessarCadastroDeUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario usuario = new CadastroUsuario(nomeUsuario,index);
            FormNavigator.OpenForm(this, usuario);
        }

        private void pictureBoxVoltarCadastro_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void iconPerfil_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario, index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }

        private void labelNomeUsuario_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario, index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }
    }
}
