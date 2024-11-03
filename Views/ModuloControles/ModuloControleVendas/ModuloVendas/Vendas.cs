using over.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over.Views.ModuloControles.ModuloControleVendas.ModuloVendas
{
    public partial class Vendas : Form
    {

        Conexao conexao = new Conexao();

        private string nomeUsuario;
        private int index;
        public Vendas(string nomeUsuario, int index)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
            labelVendas.Text = $"Vendas ({conexao.ExibirQuantidadeLinhas("Vendas")})";
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_databasefazenda_1DataSet.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this._databasefazenda_1DataSet.Vendas);

        }

        private void textBoxPesquisaProdutos_TextChanged(object sender, EventArgs e)
        {
            gridProdutos.DataSource = conexao.CarregarDados("Vendas", textBoxPesquisaPorCodigo.Text,"CodigoCompra");
            if (textBoxPesquisaPorCodigo.Text == "") labelPesquisarPorCodigoDeCompra.Text = "Pesquisar por Código de Compra";
            else labelPesquisarPorCodigoDeCompra.Text = "";
        }
        private void textBoxPesquisaIDProduto_TextChanged(object sender, EventArgs e)
        {
            gridProdutos.DataSource = conexao.CarregarDados("Vendas", textBoxPesquisaIDProduto.Text, "ID_Produto");
            if (textBoxPesquisaIDProduto.Text == "") labelPesquisaPorIDProduto.Text = "Por ID Produto";
            else labelPesquisaPorIDProduto.Text = "";
        }

        private void textBoxPesquisaIDCliente_TextChanged(object sender, EventArgs e)
        {
            gridProdutos.DataSource = conexao.CarregarDados("Vendas", textBoxPesquisaIDCliente.Text, "ID_Cliente");
            if (textBoxPesquisaIDCliente.Text == "") labelPesquisaPorIDCliente.Text = "Por ID Cliente";
            else labelPesquisaPorIDCliente.Text = "";
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

        private void btnExportarDados_Click(object sender, EventArgs e)
        {
            CriarRelatorios relatorio = new CriarRelatorios();
            relatorio.gerarRelatorioGeral("Vendas");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }
    }
}
