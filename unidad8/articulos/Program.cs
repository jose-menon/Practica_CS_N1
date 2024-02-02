namespace articulos;

class Program
{
    static void Main(string[] args)
    {
        int q, total;
        float p;

        Console.WriteLine("ingrese el precio: ");
        p = float.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la cantidad: ");
        q = int.Parse(Console.ReadLine());

        total = producto(p, q);
        
        Console.WriteLine("el total es: " + total);
    }

    static int producto(int a, int b)
    {
        int resultado;
        resultado = a * b;
        return resultado;
    }
}
