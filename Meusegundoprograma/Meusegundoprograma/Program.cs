using System;
using BLL.Interface;
using BLL;
namespace Meusegundoprograma
{
    public class Program
    {
        public static void Main()
        {
            var controller=new ExecutacalculosCTRL();
            controller.Executarcalculo(new AdicaoBLL());




            /*var controller=new ExecutaCTRL();
            controller.Validarlogin();*/

            /*var controller =new ExecutamusicaCTRL();
            var musica =new LouvorBLL();
            controller.Executarmusica(musica);
            controller.Executarautores(musica);*/




           /* var execucao = new ExecucaoBLL();
            execucao.Adicionarumdiahoje();
            execucao.Adicionarumdiamesquevem();
            execucao.Adicionarumdiaanoquevem();
            execucao.Andressanaarea("Oi");
            execucao.Numeros(17);
            execucao.Numeros(-17);*/
        }
    }
}
