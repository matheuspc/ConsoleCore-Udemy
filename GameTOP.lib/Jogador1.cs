using System;
using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public readonly string _Nome;
        public string Chuta ()
        {
            return $"{_Nome} está chutando";
        }

        public string Corre ()
        {
            return $"{_Nome} está correndo";
        }

        public string Passe ()
        {
            return $"{_Nome} está passando";
        }
    }
}