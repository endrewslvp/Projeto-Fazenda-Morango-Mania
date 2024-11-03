using over.Funcionalidades;
using over.Views.ModuloControles.ModuloControleVendas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace over {
    public partial class ConfirmarCompra : Form {

        private string nomeUsuario;
        private int index;
        private decimal total;
        private int idCliente;
        private string CodigoDeCompra;

        public List<decimal> PedidoPrecos = new List<decimal>();

        Conexao conexao = new Conexao();
        public ConfirmarCompra(string nomeUsuario, int index, Dictionary<string, decimal> Pedido, int idCliente) {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            this.idCliente = idCliente;
            labelNomeUsuario.Text = nomeUsuario;

            AdicionarDadosAoDataGridView(Pedido);
            labelTotal.Text = $"R$ {total}";
        }

        private void AdicionarDadosAoDataGridView(Dictionary<string, decimal> Pedido)
        {
            dataGridViewPedido.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(conexao.GetConnectionString()))
            {
                connection.Open();

                foreach (var item in Pedido)
                {
                    string query = "SELECT ID, Preco FROM dbo.Produtos WHERE Nome = @Nome";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", item.Key);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0); // Obtém o ID do produto
                                decimal preco = reader.GetDecimal(1); // Obtém o preço do produto

                                // Calcula o total e adiciona a linha ao DataGridView
                                total += preco * item.Value;
                                dataGridViewPedido.Rows.Add(id, item.Key, item.Value, preco, preco * item.Value);
                            }
                        }
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            GerarPedido pedido = new GerarPedido(nomeUsuario, index);
            pedido.Show();
            this.Close();
        }

        private void voltarProdutos_Click(object sender, EventArgs e)
        {
            GerarPedido pedido = new GerarPedido(nomeUsuario, index);
            pedido.Show();
            this.Close();
        }

        private void comboBoxMetodosDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodosDePagamento.SelectedIndex != -1)
            {
                btnIrParaPagamento.Enabled = true;
                btnIrParaPagamento.Text = "Confirmar 🔓";
            }
            else
            {
                btnIrParaPagamento.Enabled = false;
                btnIrParaPagamento.Text = "Confirmar🔒";
            }
            
        }

        private void btnIrParaPagamento_Click(object sender, EventArgs e)
        {
            if (comboBoxMetodosDePagamento.Text == "PIX")
            {
                EscurecimentoFundo escurecimentoFundo = new EscurecimentoFundo(this);
                escurecimentoFundo.Show();  // Exibir o fundo escurecido

                PixCode pixForm = new PixCode(total);
                pixForm.StartPosition = FormStartPosition.CenterParent; // Centralizado
                pixForm.ShowDialog(); // Exibe como modal

                // Fechar o fundo escurecido quando o PixForm for fechado
                escurecimentoFundo.Close();
                if (PixCode.status == true)
                {
                    CodigoDeCompra = GerarCodigoDeCompra.Gerar(idCliente);
                    EnviarVenda();
                    PedidoFinalizado pedidoFinalizado = new PedidoFinalizado(nomeUsuario,index,dataGridViewPedido, comboBoxMetodosDePagamento.Text,total,CodigoDeCompra);
                    pedidoFinalizado.Show();
                    this.Close();
                }
            }
        }

        private void EnviarVenda()
        {
            using (SqlConnection connection = new SqlConnection(conexao.GetConnectionString()))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewPedido.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Primeiro, insere os dados na tabela de vendas
                    string insertQuery = "INSERT INTO dbo.Vendas (ID_Cliente, ID_Produto, Quantidade, TotalCompra, CodigoCompra, MetodoPagamento) VALUES (@ID_Cliente, @ID_Produto, @Quantidade, @TotalCompra, @CodigoCompra, @MetodoPagamento)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ID_Cliente", idCliente);
                        insertCommand.Parameters.AddWithValue("@ID_Produto", row.Cells["IdProduto"].Value ?? DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@Quantidade", row.Cells["Quantidade"].Value ?? DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@TotalCompra", row.Cells["TotalCompra"].Value ?? DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@CodigoCompra", CodigoDeCompra);
                        insertCommand.Parameters.AddWithValue("@MetodoPagamento", comboBoxMetodosDePagamento.Text);

                        // Executa o comando de inserção
                        insertCommand.ExecuteNonQuery();
                    }

                    // Agora, atualiza a quantidade do produto na tabela de produtos
                    string updateQuery = "UPDATE dbo.Produtos SET QtdProduto = QtdProduto - @Quantidade WHERE Id = @ID_Produto";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Quantidade", row.Cells["Quantidade"].Value ?? 0);
                        updateCommand.Parameters.AddWithValue("@ID_Produto", row.Cells["IdProduto"].Value ?? DBNull.Value);

                        // Executa o comando de atualização
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
