using over.Relatorios;
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

namespace over
{
    public partial class InformacoesProdutos : Form
    {
        String nome;
        String quantidade;
        String validade;
        String preco;
        int index;
        public InformacoesProdutos()
        {
            InitializeComponent();
            associarTextsBox();
        }

        public void ReceberDados (String nome, String quantidade, String validade, String preco, String index)
        {
            labelInformacaoName.Text = this.nome = nome;
            labelQtdBase.Text = this.quantidade = quantidade;
            labelPrecoBase.Text = this.preco = $"R$ {preco}";
            labelValidadeBase.Text = this.validade = validade;
            this.index = Convert.ToInt32(index);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            labelInformacaoName.Text = "";
        }

        private void associarTextsBox()
        {
            textBoxNome.TextChanged += TextBoxes_TextChanged;
            textBoxQuantidade.TextChanged += TextBoxes_TextChanged;
            textBoxValidade.TextChanged += TextBoxes_TextChanged;
            textBoxPreco.TextChanged += TextBoxes_TextChanged;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxQuantidade.Text) &&
                             !textBoxValidade.MaskCompleted == false &&
                             !string.IsNullOrWhiteSpace(textBoxPreco.Text);

            btnConfirmar.Enabled = allFilled;

            if (allFilled) btnConfirmar.Text = "Confirmar 🔓";
            else btnConfirmar.Text = "Confirmar 🔒";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnConfirmar.Visible = true;
            imgBtnConfirmar.Visible = true;
            textBoxNome.Visible = true;
            textBoxQuantidade.Visible = true;
            textBoxPreco.Visible = true;
            textBoxValidade.Visible = true;
            labelInformacaoName.Text = "Nome";
            labelQtdBase.Text = "";
            labelPrecoBase.Text = "";
            labelValidadeBase.Text = "";

            labelInformacaoName.ForeColor = Color.Gray;
        }
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            var atributos = new Dictionary<string, object>
            {
                { "Nome", textBoxNome.Text},
                { "Preco", decimal.Parse(textBoxPreco.Text)},
                { "Validade", DateTime.Parse(textBoxValidade.Text)},
                { "QtdProduto", int.Parse(textBoxQuantidade.Text)}
            };

            Conexao conexao = new Conexao();
            conexao.Atualizar("Produtos",index, atributos);

            this.Close();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.Excluir("Produtos", index);
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            CriarRelatorios relatorio = new CriarRelatorios();
            var atributos = new Dictionary<string, string>
            {
                { "Nome", this.nome},
                { "Preço", this.preco },
                { "Validade", this.validade},
                { "Quantidade", this.quantidade }
            };
            relatorio.gerarRelatorioIndividuais("Tabelas",atributos);
        }
    }
}
