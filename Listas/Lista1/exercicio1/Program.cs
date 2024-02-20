using System;


class Program
{    static void Main(string[] args)
    {
        double[] notas = new double[4];
        double soma = 0, media;
        int i;

        for(i=0; i<4; i++)
        {
            Console.WriteLine("Informe a nota" + (i+1));
            notas[i] = double.Parse(Console.ReadLine());
            soma = soma+notas[i];
        }
        media = soma/i;
        Console.WriteLine("A média das " + i + "notas = " + media);
    }
}