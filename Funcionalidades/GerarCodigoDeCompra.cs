using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over.Funcionalidades
{
    internal class GerarCodigoDeCompra
    {

        public static string Gerar(int idCliente)
        {
            string code = "";

            Random random = new Random();

            code += idCliente;
            code += random.Next(0, 1001).ToString();
            code += GerarLetrasAleatorias();

            return code;

        }

        public static string GerarLetrasAleatorias()
        {
            Random random = new Random();
            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            char letra3 = (char)random.Next('A', 'Z' + 1);

            return $"{letra1}{letra2}{letra3}";
        }
    }
}
