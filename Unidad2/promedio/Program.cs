namespace promedio;

class Program
{
    static void Main(string[] args)
    {
        float nota1, nota2, nota3;
        float promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = float.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio total es de: " + promedio.ToString("0.00"));
    }
}
