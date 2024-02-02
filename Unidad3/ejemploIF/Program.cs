namespace ejemploIF;

class Program
{
    static void Main(string[] args)
    {
        int edad;

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        // if ( edad > 21)
        // {
        //     Console.WriteLine("Usted Posee un 21% de descuento");
        // }
        // else 
        // {
        //     Console.WriteLine("Usted Posee un 10% de decuento");
        // }

        if (edad > 30)
        
            Console.WriteLine("Usted posee un 30 % de descuento");
        
        else if (edad > 20)
        
            Console.WriteLine("Usted posee un 21 % de descuento");
        
        else if(edad == 18)
        
            Console.WriteLine("Usted Posee un 10 % de descuento");
        
        else
        
            Console.WriteLine("Usted Posee un 5 % de descuento");
        

        Console.WriteLine("Fin del Programa");
    }
}
