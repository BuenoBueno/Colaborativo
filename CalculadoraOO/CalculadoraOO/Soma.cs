﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO
{
    class Soma
    {
        //Cria os atributos (Características)
        public int num1, n2, total;
        public Soma()
        {
            Console.WriteLine("Objeto soma criado.");
        }

        public Soma(int num1, int num2)
        {
            this.num1 = num1;
            this.n2 = num2;
            this.total = num1 + num2;
            Console.WriteLine("Resultado da Soma: " + this.total);
        }

        public void MultEterno()
        {



        }




    }
}
