using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IAlbumBLL
    {
        DateTime ObterDataLancamento();
        string ObterAutor();
    }
}