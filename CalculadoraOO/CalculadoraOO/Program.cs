using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma variavel da Classe soma.
            Soma soma;

            //O operador "new" cria um Objeto da Classe;
            soma = new Soma();

            soma.num1 = 5;
            soma.n2 = 10;
            soma.total = soma.num1 + soma.n2;

            Console.WriteLine("Primeiro Numero: " + soma.num1);
            Console.WriteLine("Segundo Numero: " + soma.n2);

            Console.ReadKey();
        }
    }
}
