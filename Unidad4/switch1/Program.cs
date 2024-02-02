namespace switch1;

class Program
{
    static void Main(string[] args)
    {
        //switch
        char letra;

        Console.WriteLine("ingrese una letra:");
        letra = char.Parse(Console.ReadLine());

        switch(letra)
        {
            case 'M':
                Console.WriteLine("Tu nombre comienza con M....");
            break;
            case 'A':
                Console.WriteLine("Respuesta correcta");
            default:
                Console.WriteLine("Valor ingresado erroneo");
            break;
        }
    }
}
