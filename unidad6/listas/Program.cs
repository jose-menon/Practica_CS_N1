namespace listas;

class Program
{
    static void Main(string[] args)
    {
        int n, conNumeros, conImpares, grupoImparesMaximo = 0, min, conOrdenados = 0;
        double porcentajeImpares, porcentajeMaximo = -1;
        bool banderaOrdenados;

        for (int x = 0; x < 5; x++)
        {
            conNumeros = 0;
            conImpares = 0;
            banderaOrdenados = true;
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            min = n ;
            while (n != 0)
            {
                conNumeros++;
                if (n % 2 != 0)
                {
                    conImpares++;
                }

                if(n <= min)
                {
                    min = n;
                }
                else
                {
                    banderaOrdenados = false;
                }
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }
            porcentajeImpares = conImpares * 100 / conNumeros;
            if(porcentajeImpares > porcentajeMaximo)
            {
                porcentajeMaximo = porcentajeImpares;
                grupoImparesMaximo = x + 1;
            }

            if(banderaOrdenados)
            {
                conOrdenados++;
            }
        }

        Console.WriteLine("el grupo con mayor porcentaje de impares es " + grupoImparesMaximo);
        Console.WriteLine("la cantidad de grupos con numeros ordenados es: " + conOrdenados);

    }
}
