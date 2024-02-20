using System;

class Program(){
    static void Main(){
    
        // “A área do triângulo é maior que 20? False/True”
        double altura, baseTriangulo, area;
        bool validacaoArea;

        altura = double.Parse(Console.ReadLine());
        baseTriangulo = double.Parse(Console.ReadLine());
        area = (altura*baseTriangulo)/2;

        Console.WriteLine("“A área do triângulo é maior que 20? " + (validacaoArea = (area>=20)));
        
    }
}