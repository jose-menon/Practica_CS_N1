namespace vecente;

class Program
{
    static void Main(string[] args)
    {
        int n;
        int[] vNum = new int[10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero:");
            // n = int.Parse(Console.ReadLine());
            // vNum[x] = n;
            vNum[x] = int.Parse(Console.ReadLine());
        }
        int max = vNum[0];
        int pos = 0;

        for (int x = 0; x < 10; x++)
        {
            if(vNum[x] > max)
            {
                max = vNum[x];
                pos = x + 1;
            }
        }

        Console.WriteLine("el numero mayor es " + max + " y su posicion es " + pos);
    }
}
