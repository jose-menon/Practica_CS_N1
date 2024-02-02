namespace acum_cont;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0, e1 = 20, e2 = 13, e3 = 30;
        int acumulador = 0, promedio;
        //uso del metodo corto para contador y acumulador
        if (e1 > 18)
        {
            contador ++;
            acumulador += e1;
        }
        //uso del metodo largo en contador y acumulador
        if (e2 > 18)
        {
            contador = contador + 1;
            acumulador = acumulador + e2;
        }

        if (e3 > 18)
        {
            contador = contador + 1;
            acumulador += e3;
        }

        promedio = acumulador / contador;

        Console.WriteLine("El promedio es: " + promedio);
    }
}
