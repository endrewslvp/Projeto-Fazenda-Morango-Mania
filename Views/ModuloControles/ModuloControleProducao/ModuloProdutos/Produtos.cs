using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using over.Relatorios;
using over.Funcionalidades;

namespace over
{
    public partial class Produtos : Form
    {
        Conexao conexao = new Conexao();

        private string nomeUsuario;
        private int index;
        public Produtos(string nomeUsuario, int index)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
            labelProdutos.Text = $"Produtos ({conexao.ExibirQuantidadeLinhas("Produtos")})";
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_databasefazenda_1DataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this._databasefazenda_1DataSet.Produtos);
        }

        private void textBoxPesquisaProdutos_TextChanged(object sender, EventArgs e)
        {
            gridProdutos.DataSource = conexao.CarregarDados("Produtos", textBoxPesquisaProdutos.Text,"Nome");
            if (textBoxPesquisaProdutos.Text == "") labelPesquisarProduto.Text = "Pesquisar Produto";
            else labelPesquisarProduto.Text = "";
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                InformacoesProdutos informacoes = new InformacoesProdutos();

                string nome = gridProdutos.Rows[e.RowIndex].Cells["nomeDataGridViewTextBoxColumn"].Value.ToString();
                string quantidade = gridProdutos.Rows[e.RowIndex].Cells["qtdProdutoDataGridViewTextBoxColumn"].Value.ToString();
                DateTime validade = Convert.ToDateTime(gridProdutos.Rows[e.RowIndex].Cells["validadeDataGridViewTextBoxColumn"].Value);
                string validadeFormatada = validade.ToString("dd/MM/yyyy");
                string preco = gridProdutos.Rows[e.RowIndex].Cells["precoDataGridViewTextBoxColumn"].Value.ToString();
                string index = gridProdutos.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();


                EscurecimentoFundo escurecimentoFundo = new EscurecimentoFundo(this);
                escurecimentoFundo.Show();

                informacoes.ReceberDados(nome,quantidade, validadeFormatada, preco, index);
                informacoes.StartPosition = FormStartPosition.CenterParent;
                informacoes.ShowDialog();
                escurecimentoFundo.Close();

            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto cadProdutos = new CadastroProduto(nomeUsuario,index);
            FormNavigator.OpenForm(this,cadProdutos);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridProdutos.DataSource = conexao.CarregarDados("Produtos");
        }
        private void btnExportarDados_Click(object sender, EventArgs e)
        {
            CriarRelatorios relatorio = new CriarRelatorios();
            relatorio.gerarRelatorioGeral("Produtos");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }
        private void labelVoltar_Click(object sender, EventArgs e)
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
