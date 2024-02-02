namespace _20par;

class Program
{
    static void Main(string[] args)
    {
        int n, con = 0;
        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            if(par(n))
            {
                con++;
            }
        }
        Console.WriteLine("La cantidad de numeros pares son: " + con);
    }

    static bool par(int a)
    {
        if(a % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
