namespace ejemdo;

class Program
{
    static void Main(string[] args)
    {
        int n, con = 0, suma = 0;

        do
        {
            con++;
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            suma += n;
        }
        while(n != 0);

        Console.WriteLine("ingresaste " + con + " numeros que suman " + suma);
    }
}
