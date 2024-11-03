using over.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace over.Views.ModuloControles.ModuloControleVendas.ModuloClientes.ModuloCadastro
{
    public partial class CadastroCliente : Form
    {

        private string nomeUsuario;
        private int index;

        Conexao conexao = new Conexao();

        private System.Timers.Timer timer; // Timer para debounce
        private EnderecoService enderecoService; // Instância do serviço de endereço

        public CadastroCliente(string nomeUsuario, int index, string CNPJ = "")
        {
            InitializeComponent();

            this.nomeUsuario = nomeUsuario;
            this.index = index;
            labelNomeUsuario.Text = nomeUsuario;

            if(!string.IsNullOrEmpty(CNPJ) ) { maskedTextBoxCNPJ.Text = CNPJ; }

            enderecoService = new EnderecoService();

            // Inicializar o timer
            timer = new System.Timers.Timer(500); // Tempo de espera em milissegundos (0.5 segundos)
            timer.Elapsed += Timer_Elapsed; // Associa o evento Elapsed
            timer.AutoReset = false; // Para que não reinicie automaticamente

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

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "") labelTextBoxNome.Text = "Insira o nome do cliente";
            else labelTextBoxNome.Text = "";
        }

        private void maskedTextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxTelefone.Text == "") labelTextBoxTelefone.Text = "Insira o telefone";
            else labelTextBoxTelefone.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "") labelTextBoxEmail.Text = "Insira o email";
            else labelTextBoxEmail.Text = "";
        }

        private void maskedCNPJVenda_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxCNPJ.Text == "") labelTextBoxCNPJ.Text = "Insira o CNPJ";
            else labelTextBoxCNPJ.Text = "";

        }

        private void maskedTextBoxCEP_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxCEP.Text == "") labelTextBoxCEP.Text = "Insira o CEP";
            else labelTextBoxCEP.Text = "";

            timer.Stop(); // Para o timer se já estiver rodando
            timer.Start(); // Inicia o timer
        }
        private void associarTextsBox()
        {
            textBoxNome.TextChanged += TextBoxes_TextChanged;
            maskedTextBoxTelefone.TextChanged += TextBoxes_TextChanged;
            textBoxEmail.TextChanged += TextBoxes_TextChanged;
            maskedTextBoxCNPJ.TextChanged += TextBoxes_TextChanged;
            maskedTextBoxCEP.TextChanged += TextBoxes_TextChanged;
            textBoxNumero.TextChanged += TextBoxes_TextChanged;
            textBoxComplemento.TextChanged += TextBoxes_TextChanged;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                             !maskedTextBoxTelefone.MaskCompleted == false &&
                             !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                             !maskedTextBoxCNPJ.MaskCompleted == false &&
                             !maskedTextBoxCEP.MaskCompleted==false &&
                             (labelTextBoxRua.Text!="Endereço não encontrado.")&&
                             (labelTextBoxRua.Text != "Insira o CEP") &&
                             !string.IsNullOrWhiteSpace(textBoxNumero.Text) &&
                             !string.IsNullOrWhiteSpace(labelTextBoxBairro.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxComplemento.Text);

            buttonCadastrar.Enabled = allFilled;

            if (allFilled) buttonCadastrar.Text = "Cadastrar 🔓";
            else buttonCadastrar.Text = "Cadastrar 🔒";
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!conexao.VerificarCNPJNoBanco(maskedTextBoxCNPJ.Text)) {
                var atributos = new Dictionary<string, object>
                            {
                { "Nome", textBoxNome.Text },
                { "Telefone", maskedTextBoxTelefone.Text },
                { "Email", textBoxEmail.Text},
                { "CNPJ", maskedTextBoxCNPJ.Text},
                { "CEP", maskedTextBoxCEP.Text},
                { "Rua", labelTextBoxRua},
                { "Numero", textBoxNumero.Text},
                { "Bairro", labelTextBoxBairro},
                { "Complemento", textBoxComplemento.Text }
            };

                conexao.Cadastrar("Clientes", atributos);

                FormNavigator.GoBack(this);
            }
            else MessageBox.Show("CNPJ já cadastrado", "ERRO"); 
            
        }
        private void labelNomeUsuario_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario, index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }

        private void iconPerfil_Click(object sender, EventArgs e)
        {
            ControleUsuario usuariocontrol = new ControleUsuario(nomeUsuario, index);
            FormNavigator.OpenForm(this, usuariocontrol);
        }

        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string cep = maskedTextBoxCEP.Text;

            if (!string.IsNullOrWhiteSpace(cep))
            {
                Endereco endereco = await enderecoService.BuscarEndereco(cep);

                if (endereco != null)
                {
                    // Atualiza as Labels com os dados retornados
                    labelTextBoxRua.Invoke((MethodInvoker)(() => labelTextBoxRua.Text = endereco.Logradouro));
                    labelTextBoxBairro.Invoke((MethodInvoker)(() => labelTextBoxBairro.Text = endereco.Bairro));
                }
                else
                {
                    // Mensagem de erro caso não encontre o endereço
                    labelTextBoxRua.Invoke((MethodInvoker)(() => labelTextBoxRua.Text = "Endereço não encontrado."));
                    labelTextBoxBairro.Invoke((MethodInvoker)(() => labelTextBoxBairro.Text = string.Empty)); // Limpa o bairro
                }
            }
            else
            {
                // Limpa as Labels se o campo estiver vazio
                labelTextBoxRua.Invoke((MethodInvoker)(() => labelTextBoxRua.Text = string.Empty));
                labelTextBoxBairro.Invoke((MethodInvoker)(() => labelTextBoxBairro.Text = string.Empty));
            }
        }

       
    }
}
