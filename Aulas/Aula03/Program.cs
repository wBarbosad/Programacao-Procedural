using System;

class Program
{
    static void Main(string[] args){
        int idade;
        bool validacaoIdade;

        idade = int.Parse(Console.ReadLine());
        validacaoIdade = (idade>=18);
        Console.WriteLine("Essa pessoa é maior de idade? " + validacaoIdade);
    }
}