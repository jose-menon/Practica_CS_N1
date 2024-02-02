namespace parim;

class Program
{
    static void Main(string[] args)
    {
        int n, max = 0, min = 0;
        // int contpar = 0, contimpar = 0;
        bool bi = false, bp = false;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                if (bp == false)
                {
                    max = n;
                    bp = true;
                }
                else if( n > max)
                {
                    max = n;
                }
            }
            if(!bi)
            {
                min = n;
                bi = true;
            }

            else if(n < min)
                {
                    min = n;
                }

        }
            Console.WriteLine("El maximo par es: " + max);
            Console.WriteLine("El minimo impar es: " + min);
    }
}
