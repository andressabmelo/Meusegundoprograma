using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meusegundoprograma
{
    public class ExecucaoBLL
    {
        public void Adicionarumdiahoje()
        {
            Adicionarumdia(DateTime.Now);
        }
        public void Adicionarumdiamesquevem()
        {
            Adicionarumdia(DateTime.Now.AddMonths(1));
        }
        public void Adicionarumdiaanoquevem()
        {
            Adicionarumdia(DateTime.Now.AddYears(1));
        }
        public void Adicionarumdia(DateTime data)
        {
            var datafinal = data.AddDays(2);
            Console.WriteLine(datafinal);
        }
        public void Andressanaarea(string palavra)
        {
            var palavrafinal = palavra+"Andressa";
            Console.WriteLine(palavrafinal);
        }
        public void Numeros(int numero)
        {
            if(numero>0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}