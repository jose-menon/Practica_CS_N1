namespace ejemfor;

class Program
{
    static void Main(string[] args)
    {
    // for(int x = 0; x < 5; x++)
    //     {
    //         Console.WriteLine("hola mundo " + x);
    //     }
        int n, promedio, suma = 0;

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            suma += n;
        }

        promedio = suma / 5;

        Console.WriteLine("el promedio es de " + promedio);

    }
}
