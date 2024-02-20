using System;
using System.ComponentModel;

class Program(){
    static void Main(string[] args){
        int moedas_centavos;
        double converterReais, inteiroReais, conversor;

        moedas_centavos = int.Parse(Console.ReadLine());
        conversor =  (moedas_centavos/100);

        Console.WriteLine(Math.Round(conversor, 4));
        converterReais = Math.Round(conversor);
       // converterReais = Math.Round(converterReais, 2);
        Console.WriteLine(converterReais);

        double centavos = (conversor-converterReais);
        centavos = (centavos*1000);
        Console.WriteLine(centavos);

    
    }
}