namespace numeros;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, suma, producto;

        Console.WriteLine("ingrese un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese otro numero:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese otro numero:");
        c = int.Parse(Console.ReadLine());

        suma = a + b;
        producto = b * c;

        if(suma > producto)
        {
            Console.WriteLine("es mayor");
        }
        
        Console.WriteLine("fin del programa");
        
    }
}
