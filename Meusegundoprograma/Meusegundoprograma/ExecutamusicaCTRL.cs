using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
namespace Meusegundoprograma
{
    public class ExecutamusicaCTRL
    {
        public void Executarmusica(IMusicaBLL musica){
            Console.WriteLine("Você está ouvindo a rádio Beti!");
            Console.WriteLine("Fique agora com a música " + musica.Obtertitulo());
            Console.WriteLine(musica.Obterletra()+ "...");
        }
        public void Executarautores(IAlbumBLL album){
            Console.WriteLine("Esta música do autor " + album.ObterAutor());
            Console.WriteLine("Lançada em " + album.ObterDataLancamento());
        }
    }
}