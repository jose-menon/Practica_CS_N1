namespace numprim;

class Program
{
    static void Main(string[] args)
    {
        int n, con, conPrimos = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            con = 0;
            for (int y = 1; y < n; y++)
            {
                if(n % y == 0)
                {
                    con++;
                }
                if (con == 2)
                {
                    conPrimos++;
                }
                
            }
        }

        Console.WriteLine("La cantidad de primos es: " + conPrimos);
    }
}
