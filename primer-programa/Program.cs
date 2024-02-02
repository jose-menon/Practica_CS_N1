namespace primer_programa;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // int suma = 0, n;
        // for (int x = 0; x < 3; x++)
        // {
        //     Console.WriteLine("numero");
        //     n = int.Parse(Console.ReadLine());
        
        //     while (n != 0)
        //     {
        //         suma += n + 5;
        //         Console.WriteLine("numero");
        //         n = int.Parse(Console.ReadLine());
        //     }
        // }
        // Console.WriteLine("el valor " + suma);
        Console.WriteLine("numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("otro nnumero: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("el resultado es " + haceAlgo2(ref a, ref b));
        Console.WriteLine("el resultado es " + haceAlgo2(ref a, ref b));
        Console.WriteLine("el resultado es " + haceAlgo2(ref a, ref a));
    }
    static int haceAlgo2(ref int numero, ref int numero2)
    {
        int res;
        numero = numero * 2;
        numero2 = numero2 * 3;

        res = numero * numero2;

        return res;
    }
}
