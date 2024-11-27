using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace over
{
    internal class Conexao
    {
        string connectionString = "your connection strin here!";
        private SqlCommand command;

        public List<string> Coluna = new List<string>();

        string colunas = "";
        string valores = "";
        string setvalores = "";

        public Conexao()
        {
            command = new SqlCommand();
        }

        public string GetConnectionString()
        {
            return connectionString;
        }
        public int ExibirQuantidadeLinhas(string tabela)
        {

            string query = $"SELECT COUNT(*) FROM dbo.{tabela}";

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        return (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return 0;
            }
        }
        public DataTable CarregarDados(string tabela,string filtro = "",string colunaFiltro = "")
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    DescobrirColunas(tabela);

                    string query = $"SELECT Id, {colunas} FROM dbo.{tabela}";
                    if (!string.IsNullOrEmpty(filtro)&& !string.IsNullOrEmpty(colunaFiltro))
                    {
                        query += $" WHERE {colunaFiltro} LIKE @Filtro";
                    }
                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
                return null;
            }
        }  

        public void Cadastrar(string tabela, Dictionary<string, object> atributos, string dadoSemRepeticao = "")
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    colunas = string.Join(", ", atributos.Keys.Select(coluna => $"{coluna}"));
                    valores = string.Join(", ", atributos.Keys.Select(coluna => $"@{coluna}"));
                    foreach (var atributo in atributos)
                    {
                        Coluna.Add(atributo.Key);
                    }

                    if (!string.IsNullOrEmpty(dadoSemRepeticao) && atributos.ContainsKey(dadoSemRepeticao))
                    {
                        // Verifica se o valor do dadoSemRepeticao já existe no banco
                        string checkSQL = $"SELECT COUNT(1) FROM [dbo].[{tabela}] WHERE {dadoSemRepeticao} = @{dadoSemRepeticao}";
                        using (SqlCommand checkCommand = new SqlCommand(checkSQL, conexao))
                        {
                            checkCommand.Parameters.AddWithValue("@" + dadoSemRepeticao, atributos[dadoSemRepeticao]);
                            int count = (int)checkCommand.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show($"{dadoSemRepeticao} já existe no banco de dados. Cadastro não realizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    string strSQL = $"INSERT INTO [dbo].[{tabela}] ({colunas}) VALUES ({valores})";
                    using (SqlCommand command = new SqlCommand(strSQL, conexao))
                    {
                        command.Parameters.Clear();
                        for (int i = 0; i < Coluna.Count; i++)
                        {
                            object valor = atributos.ContainsKey(Coluna[i]) ? atributos[Coluna[i]] : "N/A";

                            if (valor != null)
                            {
                                if (DateTime.TryParse(valor.ToString(), out DateTime data))
                                {
                                    command.Parameters.Add("@" + Coluna[i], SqlDbType.DateTime).Value = data;
                                }
                                else if (int.TryParse(valor.ToString(), out int inteiro))
                                {
                                    command.Parameters.Add("@" + Coluna[i], SqlDbType.Int).Value = inteiro;
                                }
                                else if (decimal.TryParse(valor.ToString(), out decimal dec))
                                {
                                    command.Parameters.Add("@" + Coluna[i], SqlDbType.Decimal).Value = dec;
                                }
                                else
                                {
                                    command.Parameters.Add("@" + Coluna[i], SqlDbType.VarChar).Value = valor.ToString();
                                }
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@" + Coluna[i], DBNull.Value);
                            }
                        }
                        command.ExecuteNonQuery();
                        MessageBox.Show("Os dados fornecidos foram cadastrados com sucesso!", "Operação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }


        public void Atualizar (string tabela, int index, Dictionary<string, object> atributos, bool descobrirColunas = true)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    if (descobrirColunas)
                    {
                        DescobrirColunas(tabela);
                    }
                    else
                    {
                        Coluna.Clear();
                        setvalores = string.Join(", ", atributos.Keys.Select(coluna => $"{coluna} = @{coluna}"));
                        foreach (var atributo in atributos)
                        {
                            Coluna.Add(atributo.Key);
                        }
                    }

                    string strSQL = $@"UPDATE dbo.{tabela} SET {setvalores} WHERE Id = @Id";

                    command.Parameters.Clear();

                    using (SqlCommand command = new SqlCommand(strSQL, conexao))
                    {
                        command.Parameters.AddWithValue("@Id", index);
                        for (int i = 0; i < Coluna.Count; i++)
                        {
                            command.Parameters.AddWithValue("@" + Coluna[i], atributos.ContainsKey(Coluna[i]) ? atributos[Coluna[i]] : null);
                        }
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Dados não encontrado!");
                        }
                        command.Parameters.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        public void Excluir(string tabela, int index)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = $"DELETE FROM dbo.{tabela} WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, conexao))
                    {
                        command.Parameters.AddWithValue("@Id", index);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Dados não encontrado!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        public bool VerificarCNPJNoBanco(string cnpj)
        {
            bool encontrado = false;

            string query = "SELECT COUNT(1) FROM dbo.Clientes WHERE CNPJ = @CNPJ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CNPJ", cnpj);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        encontrado = (count > 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }

            return encontrado;
        }

        public int ObterIdPorCNPJ(string cnpj)
        {
            int id = 0;

            string query = "SELECT Id FROM dbo.Clientes WHERE CNPJ = @CNPJ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CNPJ", cnpj);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            id = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }

            return id;
        }

        public int GetProductQuantityByName(string productName)
        {
            int quantity = 0;

            string query = "SELECT QtdProduto FROM dbo.Produtos WHERE Nome = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", productName);

                try
                {
                    connection.Open();
                    quantity = (int)command.ExecuteScalar(); // Executa a consulta e obtém o resultado
                }
                catch (Exception ex)
                {
                    // Aqui você pode registrar o erro ou lançar uma exceção
                    Console.WriteLine("Erro ao obter a quantidade do produto: " + ex.Message);
                }
            }

            return quantity;
        }

        public decimal GetProductPriceByName(string productName)
        {
            decimal quantity = 0.00m;

            string query = "SELECT Preco FROM dbo.Produtos WHERE Nome = @Nome";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", productName);

                try
                {
                    connection.Open();
                    quantity = (decimal)command.ExecuteScalar(); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao obter a quantidade do produto: " + ex.Message);
                }
            }

            return quantity;
        }

        public void DescobrirColunas (string tabela)
        {
            colunas = "";
            valores = "";
            setvalores = "";
            Coluna.Clear();

            switch (tabela)
            {
                case "Produtos":
                    Coluna.Add("Nome");
                    Coluna.Add("Preco");
                    Coluna.Add("Validade");
                    Coluna.Add("QtdProduto"); 
                    break;

                case "Cadastro":
                    Coluna.Add("NomeFull");
                    Coluna.Add("CPF");
                    Coluna.Add("Cargo");
                    Coluna.Add("Email");
                    Coluna.Add("Senha");
                    break;

                case "Cargos":
                    Coluna.Add("Nome");
                    Coluna.Add("Descricao");
                    break;

                case "Clientes":
                    Coluna.Add("Nome");
                    Coluna.Add("Telefone");
                    Coluna.Add("Email");
                    Coluna.Add("CNPJ");
                    Coluna.Add("CEP");
                    Coluna.Add("Rua");
                    Coluna.Add("Numero");
                    Coluna.Add("Bairro");
                    Coluna.Add("Complemento");
                    break;

                case "Colaboradores":
                    Coluna.Add("Nome");
                    Coluna.Add("CPF");
                    Coluna.Add("Horario");
                    Coluna.Add("Cargo");
                    break;

                case "Ferramentas":
                    Coluna.Add("Nome");
                    Coluna.Add("Descricao");
                    Coluna.Add("Tipo");
                    Coluna.Add("QtdFerramenta");
                    break;

                case "Fornecedores":
                    Coluna.Add("Nome");
                    Coluna.Add("TipoFornecimento");
                    Coluna.Add("Descricao");
                    Coluna.Add("Telefone");
                    Coluna.Add("Email");
                    Coluna.Add("CNPJ");
                    Coluna.Add("Bairro");
                    Coluna.Add("Numero");
                    Coluna.Add("Rua");
                    break;

                case "Nutrientes":
                    Coluna.Add("Nome");
                    Coluna.Add("Validade");
                    Coluna.Add("Quantidade");
                    Coluna.Add("Descricao");
                    break;

                case "Sementes":
                    Coluna.Add("Nome");
                    Coluna.Add("Quantidade");
                    Coluna.Add("Descricao");
                    break;

                case "Vendas":
                    Coluna.Add("ID_Cliente");
                    Coluna.Add("ID_Produto");
                    Coluna.Add("Quantidade");
                    Coluna.Add("TotalCompra");
                    Coluna.Add("CodigoCompra");
                    Coluna.Add("MetodoPagamento");
                    break;
            }
            for (int i = 0; i < Coluna.Count; i++) { colunas += Coluna[i] + (i == Coluna.Count - 1 ? "" : ", "); }
            for (int i = 0; i < Coluna.Count; i++) { valores += "@" + Coluna[i] + (i == Coluna.Count - 1 ? "" : ", "); }
            for (int i = 0; i < Coluna.Count; i++) { setvalores += Coluna[i] + " = @" + Coluna[i] + (i == Coluna.Count - 1 ? "" : ", "); }
        }

    }
}
