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
    public partial class ControleUsuario : Form {

        private int index;
        public ControleUsuario(string nomeUsuario, int index) {

            InitializeComponent();

            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;   

            associarTextsBox();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textNome.Text) &&
                             !string.IsNullOrWhiteSpace(textEmail.Text) &&
                             !string.IsNullOrWhiteSpace(textSenha.Text);

            btnAtualizar.Enabled = allFilled;

            if (allFilled) btnAtualizar.Text = "Atualizar 🔓";
            else btnAtualizar.Text = "Atualizar 🔒";
        }
        private void associarTextsBox()
        {
            textNome.TextChanged += TextBoxes_TextChanged;
            textEmail.TextChanged += TextBoxes_TextChanged;
            textSenha.TextChanged += TextBoxes_TextChanged;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var atributos = new Dictionary<string, object>
            {
                { "NomeFull", textNome.Text },
                { "Email", textEmail.Text },
                { "Senha", textSenha.Text}
            };

            Conexao conexao = new Conexao();
            conexao.Atualizar("Cadastro",index, atributos,false);

            FormNavigator.GoBack(this);

        }

        private void pictureBoxVoltarCadastro_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }
    }
}
