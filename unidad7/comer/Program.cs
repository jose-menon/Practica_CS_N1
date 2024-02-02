namespace comer;

class Program
{
    static void Main(string[] args)
    {
        int[] vAcu = new int[15];
        int numArt, cantVen;

        Console.WriteLine("Ingrese el numero de articulo:");
        numArt = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida:");
        cantVen = int.Parse(Console.ReadLine());
        for (int x = 0; x < 15; x++)
        {
            vAcu[x] = 0;
        }
        while (numArt != 0)
        {
            vAcu[numArt - 1]+=cantVen;
            Console.WriteLine("Ingrese el numero de articulo:");
            numArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantVen = int.Parse(Console.ReadLine());
        }
        int maxCant = vAcu[0];
        int numMax = 0;
        for (int x = 0; x < 15; x++)
        {
            if(vAcu[x] > maxCant)
            {
                maxCant = vAcu[x];
                numArt = x + 1; 
            }
        }
        Console.WriteLine("el producto mas vendido es el :" + numArt + " y la cantidad vendida es: " + maxCant);

        for (int x = 0; x < 15; x++)
        {
            if(vAcu[x] == 0)
            {
                Console.WriteLine("el producto que no tuvo ventas es " + (x + 1));
            }
        }

        Console.WriteLine("la cantidad vendida del articulo 10 es " + vAcu[9]);
    }
}
