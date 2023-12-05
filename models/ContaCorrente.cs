using System;

namespace poo_csharp.models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, int saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Você retirou {valor} reais com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo indisponivel.");
            }
        }

        public void VisualizarSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}