using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;

namespace Meusegundoprograma
{
    public class ExecutacalculosCTRL
    {
        public void Executarcalculo(ICalculadoraBLL calculadora){
            Console.WriteLine("Digite dois números por favor");
            Console.ReadLine();
            Console.WriteLine("A adição dos números é: número+número ");
            Console.WriteLine("A subtração dos números é: ");
            Console.WriteLine("A multiplicação dos números é: ");
            Console.WriteLine("A divisão dos números é: ");
        }
    }
}