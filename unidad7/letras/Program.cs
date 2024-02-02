namespace letras;

class Program
{
    static void Main(string[] args)
    {
        // char[] cadena = new char[10];
        // cadena = '\0';
        // cadena[] = "hola";
        char[] nombre = new char[11];
        char letra;
        int indice = 0;

        Console.WriteLine("Ingrese su nombre letra por letra.... (termina con punto)");
        letra = char.Parse(Console.ReadLine());
        while (letra != '.' && indice < 10)
        {
            nombre[indice] = letra;
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        if(indice == 10)
        {
            indice--;
        }
        nombre[indice] = '\0';

        Console.Write("Hola ");
        indice = 0;
        while (nombre[indice] != '\0')
        {
            Console.Write(nombre[indice]);
            indice++;
        }
    }
}
