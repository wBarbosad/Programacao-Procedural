using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        int preco = int.Parse(Console.ReadLine());
        int desconto;
        desconto = preco-idade;
        System.Console.WriteLine("Preço do óculos = " + desconto);
    }
}