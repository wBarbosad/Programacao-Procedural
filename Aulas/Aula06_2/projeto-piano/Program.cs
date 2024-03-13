class Program 
{
    static void Main(string[] args)
    {
        Piano.ReproduzTecla(1,1);
        int numero = 1;
        while(numero<=7){
            Piano.ReproduzTecla(1, numero);
            numero++;
        }
    }
}