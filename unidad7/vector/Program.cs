namespace vector;

class Program
{
    static void Main(string[] args)
    {
        int n;
        int[] numeros = new int [10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese numero:");
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
        }

        int acu = 0;

        for (int x = 0; x < 10; x++)
        {
            acu += numeros[x];
            Console.WriteLine("El numero es: " + numeros[x]);
        }

        int promedio = acu / 10;

        Console.WriteLine("el promedio es " + promedio);
    }
}
