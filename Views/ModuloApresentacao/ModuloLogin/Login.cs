using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace over {
    public partial class Login : Form {

        private SqlDataReader reader;
        Conexao conexao = new Conexao();

        public Login() {
            InitializeComponent();
            associarTextsBox();
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = !CPFTextBox.MaskCompleted==false &&
                             !string.IsNullOrWhiteSpace(maskedTextPassword.Text);

            btnEntrar.Enabled = allFilled;

            if (allFilled) btnEntrar.Text = "Entrar 🔓";
            else btnEntrar.Text = "Entrar 🔒";
        }
        private void associarTextsBox()
        {
            CPFTextBox.TextChanged += TextBoxes_TextChanged;
            maskedTextPassword.TextChanged += TextBoxes_TextChanged;
        }

        private void CPFTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            MessageBox.Show("A entrada fornecida não é válida para este campo.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ((MaskedTextBox)sender).Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(this.conexao.GetConnectionString()))
                {
                    conexao.Open();
                    string strSQL = "SELECT Id, NomeFull, Cargo FROM Cadastro WHERE CPF = @CPF AND Senha = @Senha";
                    using (SqlCommand command = new SqlCommand(strSQL, conexao))
                    {
                        command.Connection = conexao;
                        command.CommandText = strSQL;
                        command.Parameters.Clear();
                        command.Parameters.Add("@CPF", SqlDbType.VarChar).Value = CPFTextBox.Text;
                        command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = maskedTextPassword.Text;
                        reader = command.ExecuteReader();
                    }
                    if (reader.HasRows)
                    {
                        reader.Read();

                        string nomeUsuario = reader["NomeFull"].ToString();
                        string cargo = reader["Cargo"].ToString();
                        int index = Convert.ToInt32(reader["Id"]);
                        reader.Close();

                        switch (cargo)
                        {
                            case "Administrador":
                                PaineldeControle painelControle = new PaineldeControle(nomeUsuario, index);
                                MessageBox.Show("Login como administrador feito com sucesso!", "Solicitação autorizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormNavigator.OpenForm(this, painelControle);
                                break;

                            case "Gerente de Venda":
                            case "Vendedor":
                                ControleVendas sistemaVendas = new ControleVendas(nomeUsuario, index,cargo);
                                MessageBox.Show($"Login feito com sucesso! Bem-vindo, {nomeUsuario}.", "Solicitação autorizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormNavigator.OpenForm(this, sistemaVendas);
                                break;

                            case "Gerente de RH":
                                ControleRh sistemaRH = new ControleRh(nomeUsuario, index);
                                MessageBox.Show($"Login feito com sucesso! Bem-vindo, {nomeUsuario}.", "Solicitação autorizada com sucesso!", MessageBoxButtons.OK);
                                FormNavigator.OpenForm(this, sistemaRH);
                                break;

                            case "Gerente de Produção":
                                ControleProducao sistemaProducao = new ControleProducao(nomeUsuario, index);
                                MessageBox.Show($"Login feito com sucesso! Bem-vindo, {nomeUsuario}.", "Solicitação autorizada com sucesso!", MessageBoxButtons.OK);
                                FormNavigator.OpenForm(this, sistemaProducao);
                                break;

                            default:
                                MessageBox.Show("O usuário inserido não foi cadastrado/reconhecido na nossa base de dados. Favor, contatar o administrador para realização de cadastro.", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF ou Senha incorretos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            
        }
    }
    
}
