namespace corte;

class Program
{
    static void Main(string[] args)
    {
        int legajo, edad, cogidoEquipo;
        float sueldo;
        int equipoActual;

        Console.WriteLine("Ingrese el legajo:");
        legajo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la edad:");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el sueldo:");
        sueldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el codigo del equipo:");
        cogidoEquipo = int.Parse(Console.ReadLine());

        while (sueldo > 0)
        {
            equipoActual = cogidoEquipo;
            
            while (cogidoEquipo == equipoActual)
            {
                

                Console.WriteLine("Ingrese el legajo:");
                legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad:");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sueldo:");
                sueldo = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el codigo del equipo:");
                cogidoEquipo = int.Parse(Console.ReadLine());
            }
        }
    }
}
