using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaPOO
{
    public class Pessoa
    {
        public string NomeCompeto { get; set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; set; }

        public Pessoa(string nomeCompeto, string email, string primeiroNome)
        {
            NomeCompeto = nomeCompeto;
            Email = email;
            PrimeiroNome = primeiroNome;
        }
    }
}
