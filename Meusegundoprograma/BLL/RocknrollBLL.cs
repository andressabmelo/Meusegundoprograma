using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL
{
    public class RocknrollBLL:IMusicaBLL
    {
        public string Obtertitulo(){
            return "Paz e amor";
        }
        public string Obterletra(){
            return "Flores na cabeça, nossos pés descalços";
        }
    }
}