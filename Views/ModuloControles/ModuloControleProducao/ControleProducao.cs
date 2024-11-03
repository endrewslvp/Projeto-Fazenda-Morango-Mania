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
    public partial class ControleProducao : Form {

        private string nomeUsuario;
        private int index;
        public ControleProducao(string nomeUsuario, int index) 
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
        }

        private void buttonFornecedor_Click(object sender, EventArgs e) 
        {

        }

        private void btnNutrientes_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos(nomeUsuario,index);
            FormNavigator.OpenForm(this, produtos);
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {

        }

        private void btnSementes_Click(object sender, EventArgs e)
        {

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

        private void pictureBoxVoltarCadastro_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void ControleProducao_Load(object sender, EventArgs e) {

        }
    }
}
