namespace ejemwhi;

class Program
{
    static void Main(string[] args)
    {
        int n, con = 0, suma = 0;

        Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

        while(n != 0)
        {
            con++;
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            suma += n;
        }

        Console.WriteLine("ingresaste " + con + " numeros que suman " + suma);

    }
}
