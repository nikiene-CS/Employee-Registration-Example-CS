using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionários
{
    public class Endereco
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }

        public Endereco(string rua, string numero, string complemento, string cep)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
        }
    }
}
