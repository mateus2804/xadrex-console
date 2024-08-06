﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.JogoXadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "B";
        }
    }
}
