using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace over.Funcionalidades
{
    public class EnderecoService
    {
        private readonly HttpClient client;

        public EnderecoService()
        {
            client = new HttpClient();
        }

        public async Task<Endereco> BuscarEndereco(string cep)
        {
            string json = await ObterEnderecoPorCep(cep);

            if (!string.IsNullOrEmpty(json))
            {
                var endereco = JsonConvert.DeserializeObject<Endereco>(json);
                return endereco;
            }

            return null; // Retorna nulo se não encontrou
        }

        private async Task<string> ObterEnderecoPorCep(string cep)
        {
            cep = cep.Replace("-", "").Trim();
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            try
            {
                var response = await client.GetStringAsync(url);
                return response;
            }
            catch (HttpRequestException e)
            {
                // Tratar exceções de requisição
                Console.WriteLine($"Erro ao chamar a API: {e.Message}");
                return null;
            }
        }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
    }
}
