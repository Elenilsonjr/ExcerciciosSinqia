using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaPratico {
    internal class Boletim {

        private int _ano;
        private int _semestre;
        public String Nome { get; set; }

        public int Ano 
        {
            get => _ano;
            
            set 
            {
                if(value < 1964) 
                {
                    throw new ArgumentException("precisa ser >1964");
                }
                _ano = value;
            }
        }

        public int Semestre {

            get => _semestre;

            set {
                if (value < 1 || value > 14) {
                    throw new ArgumentException("digite um semestre válido");
                }
                _semestre = value;
            }
        }


        public List<double> MediaMaterias { get; set; }

        public Boletim(string nome, int ano, int semestre) 
        {
            this.Nome = nome;
            this.Ano = ano;  
            this.Semestre = semestre;
        }

        public void adicionarMedias(double media) {
            //if (MediaMaterias.Count < 6) {
            MediaMaterias.Add(media);
            //}

        }

        public void ListarMedias() 
            {
            int count = 1;
            Console.WriteLine($"Médias: ");
            foreach (double media in MediaMaterias) 
            {
                Console.WriteLine($"matéria {count} - Média: {media}");
                count++;
            }
        }
        



    }
}
