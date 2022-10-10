using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DTO;
using BLL;
namespace Meusegundoprograma
{
    public class ExecutaCTRL
    {
        public void Validarlogin(){
            var login = Console.ReadLine();
            var senha = Console.ReadLine();

            var logindto = new LoginDTO();
            logindto.Senha=senha;
            logindto.Login=login;

            var loginbll=new LoginBLL();
            var resposta = loginbll.Validarlogin(logindto);
            if (resposta==true){
                Console.WriteLine("Acesso liberado");
            }
            else{
                Console.WriteLine("Acesso negado");
            }
        }
    }
}