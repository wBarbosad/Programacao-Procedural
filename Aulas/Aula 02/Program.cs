using System; //Biblioteca de entrada/saída
//Using importa coisas p/ o projeto que estamos usando;

class Program { //mesmo nome do arquivo
    static void Main(string[] args){
        double salario;
        string nome;
       
        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o seu salário: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome é: " + nome + " e seu salário é: " + salario);
       
       /* System.Console.WriteLine("Olá, mundo!");
        string nome;
        //string nomeDeUsuario = System.Console.ReadLine();

        //System.Console.WriteLine("Olá, " + nomeDeUsuario);
    
        System.Console.Write("Digite sua irmã: ");
        nome = Console.ReadLine();
        Console.WriteLine("Boa tarde, " + nome);
        */

        
    }   


}

// Estrutura básica ^
