namespace maymen;

class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Ingrese un Numero:");
        n = int.Parse(Console.ReadLine());

        if (n == 10)
        {
            Console.WriteLine("El Numero es Igual a 10");
        }
        else if (n > 10)
        {
            Console.WriteLine("El Numero es Mayor a 10");
        }
        else
        {
            Console.WriteLine("El Numero es Menor a 10");
        }
    }
}
