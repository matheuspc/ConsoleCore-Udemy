using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1("Matheus"),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }       

}
