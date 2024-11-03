using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace over.Views.ModuloControles.ModuloControleVendas.ModuloGerarPedido
{
    public partial class EspecificarQuantidade : Form
    {
        Conexao conexao = new Conexao();

        private int qtd;
        public EspecificarQuantidade(string produto)
        {
            InitializeComponent();

            qtd = conexao.GetProductQuantityByName(produto);

            labelProduto.Text = $"Tipo: {produto} - {qtd}";
            associarTextsBox();
        }

        private void associarTextsBox()
        {
            textQuantidade.TextChanged += TextBoxes_TextChanged;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textQuantidade.Text);

            btnConfirmar.Enabled = allFilled;

            if (allFilled) btnConfirmar.Text = "Confirmar 🔓";
            else btnConfirmar.Text = "Confirmar 🔒";
        }

        private void EspecificarQuantidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textQuantidade.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, preencha o campo antes de fechar o formulário.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (int.Parse(textQuantidade.Text) <= qtd)
            {
                GerarPedido.PedidoQuantidades.Add(Convert.ToInt32(textQuantidade.Text));
                this.Close();
            }
            else MessageBox.Show("Não é possível colocar uma quantidade maior que a disponível.","ATENÇÃO!");
            
        }
    }
}
