using System;

namespace poo_csharp.models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public abstract void Apresentar();
    }
}