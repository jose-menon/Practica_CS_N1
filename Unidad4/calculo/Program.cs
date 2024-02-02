namespace calculo;

class Program
{
    static void Main(string[] args)
    {
        int a, b, resultado;

        Console.WriteLine("Ingrese un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        b = int.Parse(Console.ReadLine());

        if( a > b)
        {
            resultado = a - b;
        }
        else if( a == b)
        {
            resultado = a + b;
        }
        else
        {
            resultado = a * b;
        }

        Console.WriteLine("El resultado es " + resultado);
        
    }
}
