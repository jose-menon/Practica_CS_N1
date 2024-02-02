namespace vecprom;

class Program
{
    static void Main(string[] args)
    {
        int acu = 0, prom;
        int[] vNum = new int[10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese un numero:");
            vNum[x] = int.Parse(Console.ReadLine());
            acu += vNum[x];
        }
        prom = acu / 10;
        Console.WriteLine("el promedio es " + prom);
        for (int x = 0; x < 10; x++)
        {
            if(vNum[x] > prom)
            {
                Console.WriteLine("el elemento fue mayor que el promedio " + vNum[x]);
            }
        }

        
        

    }
}
