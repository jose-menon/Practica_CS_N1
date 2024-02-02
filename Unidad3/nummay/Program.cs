namespace nummay;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, con = 0;

        Console.WriteLine("Ingrese un numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        d = int.Parse(Console.ReadLine());

        if (a > 100){
            Console.WriteLine(a);
            con++;
        }
        if (b > 100){
            Console.WriteLine(b);
            con++;
        }
        if (c > 100){
            Console.WriteLine(c);
            con++;
        }
        if (d > 100){
            Console.WriteLine(d);
            con++;
        }

        if(con != 0)
            Console.WriteLine("Hay " + con + " numeros mayores a 100");
        
        Console.WriteLine("Fin del programa");
    }
}
