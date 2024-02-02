namespace posneg;

class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Ingrese un Numero:");
        n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("El numero es igual a 0");
        }
        else if (n > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else 
        {
            Console.WriteLine("El numero es negativo");
        }
    }
}
