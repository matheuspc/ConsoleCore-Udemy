using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Passe());

            Console.WriteLine("");

            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Passe());
        }
        
    }
}