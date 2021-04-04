using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Probabilidad_de_ocurrencia
{
    class Simbolo
    {
        char caracter;
        int concurencia;

        public Simbolo(char caracter, int concurencia)
        {
            this.Caracter = caracter;
            this.Concurencia = concurencia;
        }
        public Simbolo()
        {

        }

        public char Caracter { get => caracter; set => caracter = value; }
        public int Concurencia { get => concurencia; set => concurencia = value; }

        public override string ToString()
        {
            return caracter + ": " + concurencia;
        }
    }
}
