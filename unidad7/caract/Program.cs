namespace caract;

class Program
{
    static void Main(string[] args)
    {
        char[] cadena = new char[30];
        char letraActual;
        char letraNueva;
        char letra;
        int indice = 0;

        Console.WriteLine("ingrese una letra: ");
        letra = char.Parse(Console.ReadLine());
        while (letra != '0' && indice < 30)    
        {
            cadena[indice] = letra;
            Console.WriteLine("ingrese otra letra: ");
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        cadena[indice] = '\0';
        Console.WriteLine("la frase completa es: ");
        indice = 0;
        while (cadena[indice] != '\0')  
        {
            Console.Write(cadena[indice]);
            indice++;
        }

        Console.WriteLine("ingrese letra a reemplazar: ");
        letraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la letra nueva:");
        letraNueva = char.Parse(Console.ReadLine());
        indice = 0;
        while (cadena[indice] != '\0')
        {
            if(cadena[indice] == letraActual)
            {
                cadena[indice] = letraNueva;
                indice++;
            }
        }

        Console.WriteLine("La frase nueva es: ");
        indice = 0;
        while (cadena[indice] != '\0')
        {
            Console.Write(cadena[indice]);
            indice++;
        }

        // METODO ORIENTADO A OBJETOS
        // string cadena;
        // char letraActual;
        // char letraNueva;
        // Console.WriteLine("ingrese la frase: ");
        // cadena = Console.ReadLine();
        // Console.WriteLine("Ingrese la letra a reemplazar:");
        // letraActual = char.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese la letra nueva: ");
        // letraNueva = char.Parse(Console.ReadLine());

        // cadena = cadena.Replace(letraActual , letraNueva);

        // Console.WriteLine("la nueva frase es: ");
        // Console.WriteLine(cadena);


    }
}
