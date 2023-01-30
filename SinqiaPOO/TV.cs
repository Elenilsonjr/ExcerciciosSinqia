using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaPOO
{
    public class TV
    {
        public int Canal { get; set; }
        public string Volume { get; set; }
        public string Ligada { get; set; }

        public TV(int canal, string volume, string ligada)
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }

        public bool Liga(string ligada)
        {
            if (ligada == "sim")
            {
                return true;
            }
            else
            {
                Console.WriteLine("A Tv está desligada");
                return false;
            }
        }

        public void TrocarDeCanal(int canal)
        {
            Canal = canal;
        }

        public void AumentaVolume(string volumeMais)
        {
            Volume = volumeMais;
        }

        public void DimunueVolume(string volumeMenos)
        {
            Volume = volumeMenos;
        }


    }
}
