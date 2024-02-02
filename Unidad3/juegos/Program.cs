namespace juegos;

class Program
{
    static void Main(string[] args)
    {
        float importe;
        

        Console.WriteLine("Ingrese el precio del producto:");
        importe = float.Parse(Console.ReadLine());

        if (importe >= 1000)
        {
            if (importe >= 5000)
            importe = importe * 0.82F;
            else
            importe = importe * 0.90F;
        
        }
        

        Console.WriteLine("El total a pagar es " + importe + " Pesos");
    }
}
