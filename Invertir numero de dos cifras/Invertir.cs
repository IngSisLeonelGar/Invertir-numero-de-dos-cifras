using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_numero_de_dos_cifras
{
    internal class Invertir
    {
        static void Main(String[] args)
        {
            int num, aux, dec, uni;
            string linea;
            Console.WriteLine("Ingrese numero de dos cifras: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            dec = num / 10;
            uni = num % 10;
            aux = (uni * 10) + dec;
            Console.WriteLine("Numero invertido es: " + aux);
            Console.WriteLine("Pulse una tecla: ");
            Console.ReadLine();
        }
    }
}
