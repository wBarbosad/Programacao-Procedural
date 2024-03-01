using System;
class Program{
    static void Main(string[] args){
        string nome = Console.ReadLine();
        string senha = Console.ReadLine();

        if (senha=="123senha" && nome=="admin"){
            System.Console.WriteLine("Login realizado com sucesso!");
        }
        else{
            System.Console.WriteLine("Credenciais inválidas!");
        }
    }
}