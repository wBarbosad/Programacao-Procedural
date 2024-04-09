using System;

class Program{

    struct Enxadrista{
        public int id;
        public string nome;
        public int rating;

    }
    static void Main(string[] args){
        Enxadrista[] enxadrista = new Enxadrista[2];

        GetEnxadrista(SetEnxadrista(enxadrista)); //Entra na função SetEnxadrista, preenche e depois vai no GetEnxadrista e imprimir;
    }

    static Enxadrista[] SetEnxadrista(Enxadrista[] enxadrista){
        
        for(int i=0; i<enxadrista.Length; i++){
            enxadrista[i].id = int.Parse(Console.ReadLine());
            enxadrista[i].nome = Console.ReadLine();
            enxadrista[i].rating = int.Parse(Console.ReadLine());
        }
        return enxadrista;
    }
    static void GetEnxadrista(Enxadrista[] enxadrista){
        
        for(int i=0; i<enxadrista.Length; i++){
            System.Console.WriteLine("Id: " + enxadrista[i].id + "\nNome: " + enxadrista[i].nome + "\nRating: " + enxadrista[i].rating + "\n");

        }
    }
}