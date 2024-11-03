using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace over {
    public partial class CadastroUsuario : Form {

        private string nomeUsuario;
        private int index;
        public CadastroUsuario(string nomeUsuario, int index) {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;

            associarTextsBox();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textNome.Text) &&
                             !textCPF.MaskCompleted == false &&
                             !string.IsNullOrWhiteSpace(comboEscolhaCargo.Text) &&
                             !string.IsNullOrWhiteSpace(textEmail.Text) &&
                             !string.IsNullOrWhiteSpace(textSenha.Text);

            btnCadastrar.Enabled = allFilled;

            if (allFilled) btnCadastrar.Text = "Cadastrar 🔓";
            else btnCadastrar.Text = "Cadastrar 🔒";
        }
        private void associarTextsBox()
        {
            textNome.TextChanged += TextBoxes_TextChanged;
            textCPF.TextChanged += TextBoxes_TextChanged;
            comboEscolhaCargo.TextChanged += TextBoxes_TextChanged;
            textEmail.TextChanged += TextBoxes_TextChanged;
            textSenha.TextChanged += TextBoxes_TextChanged;
        }

        private void CPFTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            
            MessageBox.Show("A entrada fornecida não é válida para este campo.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ((MaskedTextBox)sender).Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            textCPF.Text = "";
            comboEscolhaCargo.Text = "";
            textEmail.Text = "";
            textSenha.Text = "";
        }

        private void pictureBoxVoltarCadastro_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var atributos = new Dictionary<string, object>
            {
                { "NomeFull", textNome.Text },
                { "CPF",textCPF.Text},
                { "Cargo",comboEscolhaCargo.Text},
                { "Email", textEmail.Text },
                { "Senha", textSenha.Text},
            };

            Conexao conexao = new Conexao();
            conexao.Cadastrar("Cadastro", atributos,"CPF");
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
