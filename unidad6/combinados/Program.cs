namespace combinados;

class Program
{
    static void Main(string[] args)
    {
        //for con for
        // int prom, n, acum;
        // for (int y = 0; y < 10; y++)
        // {
        //     acum = 0;
        //     for (int x = 0; x < 10; x++)
        //     {
        //         Console.WriteLine("Ingrese edades: ");
        //         n = int.Parse(Console.ReadLine());
        //         acum += n;
        //     }
        //     prom = acum / 20;
        //     Console.WriteLine("El promedio es " + prom);
        // }

        //for con while
        // for (int x = 0; x < 10; x++)
        // {
        //     Console.WriteLine("Ingrese edades: ");
        //     n = int.Parse(Console.ReadLine());
        //     acu = 0;
        //     con = 0;
        //     int prom;
        //     while (n != 0)
        //     {
        //         acum += n;
        //         con++;
        //         Console.WriteLine("Ingrese edades: ");
        //         n = int.Parse(Console.ReadLine());
                
        //     }
        //     prom = acum / 20;
        //     Console.WriteLine("El promedio es " + prom);
        // }
        //while con for

        // int n;

        // Console.WriteLine("Ingrese 1 para empezar o 0 para terminar");
        // n = int.Parse(Console.ReadLine());
        // while (true)
        // {
        //     acum = 0;
        //     for (int x = 0; x < 10; x++)
        //     {
        //         Console.WriteLine("Ingrese edades: ");
        //         n = int.Parse(Console.ReadLine());
        //         acum += n;
        //     }
        //     prom = acum / 20;
        //     Console.WriteLine("El promedio es " + prom);
        // }
        // Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
        // n = int.Parse(Console.ReadLine());
        //while con while
        Console.WriteLine("Ingrese edades: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            acu = 0;
            con = 0;
            int prom;
            while (n != 0)
            {
                acum += n;
                con++;
                Console.WriteLine("Ingrese edades: ");
                n = int.Parse(Console.ReadLine());
                
            }
            prom = acum / 20;
            Console.WriteLine("El promedio es " + prom);

            Console.WriteLine("Ingrese una edad para continuar o un negativo para cortar");
            n = int.Parse(Console.ReadLine());
            
        }


    }
}
