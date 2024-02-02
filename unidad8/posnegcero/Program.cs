namespace posnegcero;

class Program
{
    static void Main(string[] args)
    {
        int numero, status = 0, pos = 0, neg = 0, cero = 0, ban = 0;

        Console.WriteLine("ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        posNegCer(numero, ref status);
    }

    static void posNegCer(int valor, ref int estado)
    {
        if(valor == 0)
        {
            estado = 0;
        }
        else if(valor > 0)
        {
            estado = 1;
        }
        else
        {
            estado = -1;
        }
    }
}
