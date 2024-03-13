using System;

class Program{
    static void Main(string[] args){
        double soma = 0, media;
        int contador = 0;
        double[] notas = new double[4]; 
        for(contador=0; contador<4; contador++){
            notas[contador] = double.Parse(Console.ReadLine());
            soma = soma + notas[contador];
            System.Console.WriteLine(notas[contador]);
        }
        media = soma/contador;
        System.Console.WriteLine(media);
        if(media>=5.0){
            System.Console.WriteLine("Aluno(a) aprovado(a)");
        }
        else if(media<5 && media>=3){
            System.Console.WriteLine("Aluno(a) em recuperação");
        }
        else{
            System.Console.WriteLine("Aluno reprovado com média = " + media);
        }
    }
}