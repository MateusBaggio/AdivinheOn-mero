using System.Security.Cryptography;

string nome;
Random aleatorio = new Random();
int valor = aleatorio.Next(1, 100);



void BoasVindas()
{
    Console.WriteLine("Olá, Seja bem vindo!!!");
    Console.Write("\nDigite o seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Olá, " + nome);
}

void Jogo()
{
    Console.WriteLine("\n  Vamos começar!!!");
    Console.WriteLine("  O jogo funciona da Seguinte forma: \n  Eu irei sortear um número entre 1 e 100 e você,");
    Console.WriteLine("  Terá que adivinhar esse número com base em minhas dicas.");
    Console.WriteLine("  Tudo pronto? ");

    do { 
    Console.Write("\n  De o seu palpite: ");
        string ler = Console.ReadLine();
        int opcaoLida = int.Parse(ler);
        


        if (opcaoLida == valor)
    {
        Console.WriteLine("Parabéns, você acertou!!!" + valor);
            break;
    }
    else if (opcaoLida < valor)
    {
        Console.WriteLine("  Tente um valor maior");
    }
    else if (opcaoLida > valor)
    {
        Console.WriteLine("  Tente um valor menor");
    }
    else { 
        Console.WriteLine("  O valor deve ser de 1 à 100");
    }

    }
    while (true);
}

BoasVindas();
Jogo();



