using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaPOO
{
    public class Caneta
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }

        public Caneta(string cor, string marca, double preco)
        {
            Cor = cor;
            Marca = marca;
            Preco = preco;
        }
    }
}
