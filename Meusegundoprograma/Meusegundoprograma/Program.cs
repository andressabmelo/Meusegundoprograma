﻿using System;

namespace Meusegundoprograma
{
    public class Program
    {
        public static void Main()
        {
            var execucao = new ExecucaoBLL();
            execucao.Adicionarumdiahoje();
            execucao.Adicionarumdiamesquevem();
            execucao.Adicionarumdiaanoquevem();
            execucao.Andressanaarea("Oi");
            execucao.Numeros(17);
            execucao.Numeros(-17);
        }
    }
}
