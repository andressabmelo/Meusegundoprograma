using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL
{
    public class LouvorBLL :IMusicaBLL,IAlbumBLL
    {
        public string Obtertitulo(){
            return "Promessas";
        }
        public string Obterletra(){
            return "Fiel tu és senhor";
        }
        public DateTime ObterDataLancamento(){
            return new DateTime().AddYears(2022).AddMonths(6).AddDays(9);
        }
        public string ObterAutor(){
            return "Daniela e Jessé";
        }
    }
}