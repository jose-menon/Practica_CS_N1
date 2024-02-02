namespace decre;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d;

        Console.WriteLine("Ingrese un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        d = int.Parse(Console.ReadLine());

        if(a > b && b > c && c > d)
        {
            Console.WriteLine("El orden es decreciente");
        }
        else
        {
            Console.WriteLine("El orden no es decreciente");
        }
    }
}
