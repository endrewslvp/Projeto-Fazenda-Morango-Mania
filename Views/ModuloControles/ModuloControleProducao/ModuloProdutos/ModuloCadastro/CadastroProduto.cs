using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace over
{
    public partial class CadastroProduto : Form
    {
        private string nomeUsuario;
        private int index;
        public CadastroProduto(string nomeUsuario, int index)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
            associarTextsBox();
        }

        private void voltarProdutos_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProduto.Text == "") labelTextBoxNome.Text = "Insira o nome do produto";
            else labelTextBoxNome.Text = "";
        }

        private void textBoxQtd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQtd.Text == "") labelTextBoxQtd.Text = "Insira a qtd";
            else labelTextBoxQtd.Text = "";
        }

        private void textBoxValidade_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValidade.Text == "") labelTextBoxValidade.Text = "Insira a validade";
            else labelTextBoxValidade.Text = "";
        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPreco.Text == "") labelTextBoxPreco.Text = "Insira o preço";
            else labelTextBoxPreco.Text = "";
        }

        private void associarTextsBox()
        {
            textBoxProduto.TextChanged += TextBoxes_TextChanged;
            textBoxQtd.TextChanged += TextBoxes_TextChanged;
            textBoxValidade.TextChanged += TextBoxes_TextChanged;
            textBoxPreco.TextChanged += TextBoxes_TextChanged;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textBoxProduto.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxQtd.Text) &&
                             !textBoxValidade.MaskCompleted==false&&
                             !string.IsNullOrWhiteSpace(textBoxPreco.Text);

            buttonCadastrar.Enabled = allFilled;

            if (allFilled) buttonCadastrar.Text = "Cadastrar 🔓";
            else buttonCadastrar.Text = "Cadastrar 🔒";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte os valores para os tipos apropriados
                var nomeProduto = textBoxProduto.Text;
                var precoProduto = decimal.Parse(textBoxPreco.Text);
                var validadeProduto = DateTime.Parse(textBoxValidade.Text);
                var quantidadeProduto = int.Parse(textBoxQtd.Text);

                // Cria o dicionário com os valores convertidos
                var atributos = new Dictionary<string, object>
                {
                    { "Nome", nomeProduto },
                    { "Preco", precoProduto },
                    { "Validade", validadeProduto },
                    { "QtdProduto", quantidadeProduto }
                };

                Conexao conexao = new Conexao();
                conexao.Cadastrar("Produtos", atributos);

                FormNavigator.GoBack(this);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
