using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL
{
    public class MultiplicacaoBLL : ICalculadoraBLL
    {
        public int Calcular(int valor1,int valor2){
            var resultado=valor1 * valor2;
            return resultado;
        }
    }
}