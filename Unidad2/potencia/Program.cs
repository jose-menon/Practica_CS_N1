namespace potencia;

class Program
{
    static void Main(string[] args)
    {
        int n1;
        int resultado;

        Console.WriteLine("Ingrese un numero:");
        n1 = int.Parse(Console.ReadLine());
        resultado = n1 * n1 * n1;
        Console.WriteLine("El cubo del numero ingresado es: " + resultado);
    }
}
