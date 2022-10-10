using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DTO;

namespace BLL
{
    public class LoginBLL
    {
        public bool Validarlogin(LoginDTO login){
            if (login.Login=="Calu@gmail.com"){
                if (login.Senha=="Cacau"){
                    return true;
                }
            }
            return false;
            
        }
    }
}