using System;

class program
{
    static void main()
    {
        // Perguntar o nome do personagem 
        Console.WriteLine("Digite o nome do personagem:");
        string nome = Console.ReadLine();

    int vida = 100;
    int moedas = 0;
    int nivel = 1;

    Console.WriteLine("\n===== FICHA DO PERSONAGEM =====");
    Console.WriteLine("Nome: "+ nome);
    Console.WriteLine("Vida: " + vida);
    Console.WriteLine("Moedas: " + moedas);
    Console.WriteLine("Nível: " + nivel);
    Console.WriteLine("==========================");
    }
}