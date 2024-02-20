using System;

class Program(){
    static void Main(string[] args){
        double moedas_centavos;
        double conversorInteiro, conversor;

        moedas_centavos = int.Parse(Console.ReadLine());
        conversor = moedas_centavos/100;
        conversorInteiro = Math.Round(conversor);
        Console.WriteLine("Reais: " + conversorInteiro + " Fracionado " + );

    }
}