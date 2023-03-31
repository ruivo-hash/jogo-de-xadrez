using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.Tabuleiro;

namespace xadrez_console.Xadrez
{
    public class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }
        

        public PosicaoXadrez(char coluna, int linha)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Linha + Coluna;
        }
    }
}
