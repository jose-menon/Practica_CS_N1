namespace desinfec;

class Program
{
    static void Main(string[] args)
    {
        float importe, litros;

        Console.WriteLine("Ingrese el importe");
        importe = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los litros");
        litros = float.Parse(Console.ReadLine());

        if(litros > 100 && litros <= 300)
        {
            importe = importe * 0.90F;
        }
        else if(litros > 300 && litros <= 500)
        {
            importe = importe * 0.85F;
        }
        else if(litros > 500)
        {
            importe = importe * 0.75F;
        }

        Console.WriteLine("El importe a pagar es " + importe + " Pesos");
    }
}
