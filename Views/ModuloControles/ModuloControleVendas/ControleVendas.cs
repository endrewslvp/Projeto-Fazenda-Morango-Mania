using over.Views.ModuloControles.ModuloControleVendas.ModuloClientes;
using over.Views.ModuloControles.ModuloControleVendas.ModuloVendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over {
    public partial class ControleVendas : Form {

        private string nomeUsuario;
        private int index;
        private string cargo;
        public ControleVendas(string nomeUsuario, int index, string cargo = "") {
            
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            this.cargo = cargo;
            labelNomeUsuario.Text = nomeUsuario;
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

        private void voltarProdutos_Click(object sender, EventArgs e)
        {
            if (cargo == "Administrador")
            {
                PaineldeControle painel = new PaineldeControle(nomeUsuario, index);
                FormNavigator.OpenForm(this, painel);
            }
            else FormNavigator.GoBack(this);
            
        }

        private void btnGerarPedido_Click(object sender, EventArgs e)
        {
            GerarPedido pedido = new GerarPedido(nomeUsuario, index);
            FormNavigator.OpenForm(this, pedido);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas(nomeUsuario,index);
            FormNavigator.OpenForm(this, vendas);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(nomeUsuario,index);
            FormNavigator.OpenForm(this, clientes);
        }
    }
}
