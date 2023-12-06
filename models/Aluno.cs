using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace poo_csharp.models
{
    public sealed class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um Aluno nota {Nota}");
        }
    }
}

/*
sealed = sela uma class e n tem como ela ter classes filhas, tbm serve pra métodos, para q n exista a possibilidade de sobrescrever tal método;

override = sobrescreve o método q herdou da class pai;

 : = serve para que a class herde de uma outra class;

abstract = transforma a class em uma classe abstrata, ou seja, ela n pode ser instaciada, apenas as classes filhas dela serão instanciadas;

virtual = torna tbm um método sobrescrevivel KKK.
 */