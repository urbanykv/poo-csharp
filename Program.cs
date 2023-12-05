using System.Buffers.Text;
using poo_csharp.models;

bool programa = true;
ContaCorrente conta = new(135, 1500);

while(programa)
{
    Console.WriteLine("Bem vindo ao Banco.");
    Console.WriteLine("1 - visualizar saldo\n2 - sacar\n3 - Encerrar o programa");
    int numero = int.Parse(Console.ReadLine());
    if(numero == 1)
    {
        conta.VisualizarSaldo();
    }
    else if(numero == 2)
    {
        int valor = int.Parse(Console.ReadLine());
        conta.Sacar(valor);
    }
    else if(numero == 3)
    {
        Console.WriteLine("Programa finalizado com sucesso!");
        programa = false;
    }
    else if(numero > 3 || numero < 1)
    {
        Console.WriteLine("Número Incorreto.");
    }
}

Aluno a = new()
{
    Nome = "Matheus",
    Idade = 21,
    Nota = 10
};

a.Apresentar();