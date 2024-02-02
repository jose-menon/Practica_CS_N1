namespace sueldo;

class Program
{
    static void Main(string[] args)
    {
        const float sueldo = 15000;
        // int comision = 5;
        const float comision = 0.05F;
        // int facturacion, sueldoBruto;
        float facturacion, sueldoBruto;

        Console.WriteLine("Ingrese total facturado en el mes:");
        // facturacion = int.Parse(Console.ReadLine());
        facturacion = float.Parse(Console.ReadLine());

        // sueldoBruto = ((facturacion * comision)/100) + sueldo;
        sueldoBruto = (facturacion * comision) + sueldo;

        Console.WriteLine("Su sueldo total del mes es de: " + sueldoBruto + " pesos");

    }
}
