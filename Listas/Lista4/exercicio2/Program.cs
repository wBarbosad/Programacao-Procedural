using System;

class Program()
{
    static void Main(string[] arg)
    {
        double altura;
        do
        {
            altura = double.Parse(Console.ReadLine());
            if (altura < 1 || altura > 9)
            {
                System.Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9");
            }
        } while (altura < 1 || altura > 9);
        for(int i=1; i<=altura; i++){
             System.Console.WriteLine(i);
            for(int j=0; j<=i; j++){
                Console.WriteLine(j+1);
    
            }
        }
    }


}