using System;

class Program{
    static void Main(string[] args){
        int[] idade = new int[3];

        for(int i = 0; i<3; i++){
            idade[i] = int.Parse(System.Console.ReadLine());
        }
        for(int i = 2; i>=0; i--){
            System.Console.WriteLine(idade[i]);
        }
    }
}