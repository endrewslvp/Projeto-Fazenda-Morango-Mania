using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over.Views.ModuloControles.ModuloControleVendas
{
    public partial class PedidoFinalizado : Form
    {
        private string nomeUsuario;
        private int index;

        private DataGrid dados;
        public PedidoFinalizado(string nomeUsuario, int index, DataGridView dados, string MetodoDePagamento, decimal total, string CodigoDeCompra)
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;
            labelMetodoDePagamento.Text = MetodoDePagamento;
            labelValorTotal.Text = $"R$ {total.ToString()}";
            labelCodigoDeCompra.Text = CodigoDeCompra;

            foreach (DataGridViewRow linha in dados.Rows)
            {
                if (!linha.IsNewRow)
                {
                    int indice = dataGridViewPedido.Rows.Add();
                    for (int i = 0; i < linha.Cells.Count; i++)
                    {
                        dataGridViewPedido.Rows[indice].Cells[i].Value = linha.Cells[i].Value;
                    }
                }
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

        private void btnVoltarParaOInicio_Click(object sender, EventArgs e)
        {
            ControleVendas vendas = new ControleVendas(nomeUsuario, index);
            FormNavigator.OpenForm(this, vendas);
        }
    }
}
