using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blastoff
{
    internal class Questao02
    {
        private static void Main(string[] args)
        {
            int Distanca, CombustivelGasto;

            Distanca = 5;
            CombustivelGasto = 5;

            int MediaDeConbustivelGastoPorDistancia = Distanca / CombustivelGasto;

            Console.WriteLine("MediaDeCombustivelGastoPorDistancia = " + MediaDeConbustivelGastoPorDistancia);
            Console.ReadKey();
        }
    }
}
