using over.Relatorios;
using over.Views.ModuloControles.ModuloControleVendas.ModuloClientes.ModuloCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over.Views.ModuloControles.ModuloControleVendas.ModuloClientes
{
    public partial class Clientes : Form
    {
        Conexao conexao = new Conexao();

        private string nomeUsuario;
        private int index;
        public Clientes(string nomeUsuario, int index)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
            labelClientes.Text = $"Clientes ({conexao.ExibirQuantidadeLinhas("Clientes")})";
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_databasefazenda_1DataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this._databasefazenda_1DataSet.Clientes);

        }

        private void textBoxPesquisaPorNome_TextChanged(object sender, EventArgs e)
        {
            gridClientes.DataSource = conexao.CarregarDados("Clientes", textBoxPesquisaPorNome.Text, "Nome");
            if (textBoxPesquisaPorNome.Text == "") labelPesquisarPorNome.Text = "Pesquisar por Nome";
            else labelPesquisarPorNome.Text = "";
        }

        private void textBoxPesquisaPorCNPJ_TextChanged(object sender, EventArgs e)
        {
            gridClientes.DataSource = conexao.CarregarDados("Clientes", textBoxPesquisaPorCNPJ.Text, "CNPJ");
            if (textBoxPesquisaPorCNPJ.Text == "") labelPesquisarPorCNPJ.Text = "Pesquisar por CNPJ";
            else labelPesquisarPorCNPJ.Text = "";
        }

        private void textBoxPesquisaPorCEP_TextChanged(object sender, EventArgs e)
        {
            gridClientes.DataSource = conexao.CarregarDados("Clientes", textBoxPesquisaPorCEP.Text, "CEP");
            if (textBoxPesquisaPorCEP.Text == "") labelPesquisarPorCEP.Text = "Pesquisar por CEP";
            else labelPesquisarPorCEP.Text = "";
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
            relatorio.gerarRelatorioGeral("Clientes");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void labelVoltar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridClientes.DataSource = conexao.CarregarDados("Clientes");
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cliente = new CadastroCliente(nomeUsuario,index);
            FormNavigator.OpenForm(this,cliente);
        }
    }
}
