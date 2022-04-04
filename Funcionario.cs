using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Funcionários
{
    public class Funcionario
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public Endereco Endereco { get; private set; }

        public Funcionario(long id, string nome, string cpf, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}
