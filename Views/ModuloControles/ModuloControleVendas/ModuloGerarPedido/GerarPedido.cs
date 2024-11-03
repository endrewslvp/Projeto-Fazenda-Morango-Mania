using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using over.Views.ModuloControles.ModuloControleVendas.ModuloGerarPedido;
using System.Data;
using over.Funcionalidades;
using over.Views.ModuloControles.ModuloControleVendas.ModuloClientes.ModuloCadastro;

namespace over {
    public partial class GerarPedido : Form {

        private string nomeUsuario;
        private int index;

        public List<string> produtos = new List<string>();

        public static List<decimal> PedidoQuantidades = new List<decimal>();
        public static List<string> PedidoProdutos = new List<string>();

        Conexao conexao = new Conexao();
        public GerarPedido(string nomeUsuario, int index) {
           
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;

            ListarProdutos();
            associarTextsBox();
        }

        public void ListarProdutos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexao.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT Nome FROM Produtos";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedListBoxProdutos.Items.Add($"{reader.GetString(0)} ({conexao.GetProductQuantityByName(reader.GetString(0))}) - R$ {conexao.GetProductPriceByName(reader.GetString(0))}");
                            produtos.Add(reader.GetString(0)); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void checkedListBoxProdutos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string produto = produtos[e.Index];

            if (e.NewValue == CheckState.Checked)
            {
                EscurecimentoFundo escurecimentoFundo = new EscurecimentoFundo(this);
                escurecimentoFundo.Show();

                EspecificarQuantidade especificarQuantidade = new EspecificarQuantidade(produto);
                especificarQuantidade.StartPosition = FormStartPosition.CenterParent; // Centralizado
                especificarQuantidade.ShowDialog(); // Exibe como modal

                escurecimentoFundo.Close();

                PedidoProdutos.Add(produto);

            }
            else
            {
                PedidoQuantidades.RemoveAt(PedidoProdutos.IndexOf(produto));
                PedidoProdutos.Remove(produto);
            }
        }

        private void associarTextsBox()
        {
            maskedCNPJVenda.TextChanged += TextBoxesOrItemCheckChanged;
            checkedListBoxProdutos.ItemCheck += TextBoxesOrItemCheckChanged;
        }

        private void TextBoxesOrItemCheckChanged(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)AtualizarBotaoPagamento);
        }

        private void AtualizarBotaoPagamento()
        {
            bool allFilled = maskedCNPJVenda.MaskCompleted &&
                             checkedListBoxProdutos.CheckedItems.Count > 0;

            btnIrParaPagamento.Enabled = allFilled;
            btnIrParaPagamento.Text = allFilled ? "Ir para Pagamento 🔓" : "Ir para Pagamento 🔒";
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

        private void btnIrParaPagamento_Click(object sender, EventArgs e)
        {
            if (conexao.VerificarCNPJNoBanco(maskedCNPJVenda.Text))
            {
                Dictionary<string, decimal> Pedido = new Dictionary<string, decimal>();
                for (int i = 0; i < PedidoProdutos.Count; i++)
                {
                    Pedido.Add(PedidoProdutos[i], PedidoQuantidades[i]);
                }
                PedidoProdutos.Clear();
                PedidoQuantidades.Clear();
                ConfirmarCompra compra = new ConfirmarCompra(nomeUsuario, index, Pedido, conexao.ObterIdPorCNPJ(maskedCNPJVenda.Text));
                compra.Show();
                this.Hide();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("CNPJ não encontrado.\nDeseja cadastrar o cliente?", "ERRO", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    CadastroCliente cliente = new CadastroCliente(nomeUsuario, index, maskedCNPJVenda.Text);
                    FormNavigator.OpenForm(this, cliente);
                }
            }
        }

        private void voltarProdutos_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormNavigator.GoBack(this);
        }
    }
}
