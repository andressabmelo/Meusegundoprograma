using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL;

namespace Meusegundoprograma
{
    public class ExecutacalculosCTRL
    {
        public void Executarcalculo(ICalculadoraBLL calculadora){
            Console.WriteLine("Digite dois números por favor");
            var valor1 = Convert.ToInt32( Console.ReadLine());
            var valor2 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("O resultado da sua conta é:" + calculadora.Calcular(valor1,valor2));


        }
    }
}