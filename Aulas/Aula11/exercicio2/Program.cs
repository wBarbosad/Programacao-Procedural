using System;

class Program{
    static void Main(string[] args)
    {
        string[] nome = new string[3];
        

        for(byte i = 0; i<nome.Length; i++){
            nome[i] = Console.ReadLine();
            if(nome[i]=="Jose"){    
                
            }
            else{
                System.Console.WriteLine("Nome não encontrado.");
            }
        }
    }
    
}