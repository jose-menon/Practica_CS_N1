namespace distancia;

class Program
{
    static void Main(string[] args)
    {
        // int distancia;
        // int velocidad;
        // int tiempo;
        float distancia, velocidad, tiempo;

        Console.WriteLine("Ingrese distancia");
        // distancia = int.Parse(Console.ReadLine());
        distancia = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Velocidad promedio del Vehiculo");
        // velocidad = int.Parse(Console.ReadLine());
        velocidad = float.Parse(Console.ReadLine());
        
        tiempo = (distancia / velocidad);

        Console.WriteLine("El tiempo estimado para su destino es de: " + tiempo.ToString("0.00") + " Horas");

    }
}
