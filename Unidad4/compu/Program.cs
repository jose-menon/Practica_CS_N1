namespace compu;

class Program
{
    static void Main(string[] args)
    {
        int procesador, memoria, disco;
        float precio = 0;

        Console.WriteLine("Ingrese la opcion de procesador:");
        procesador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la opcion de la memoria:");
        memoria = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese si desea ampliar o no el disco:");
        disco = int.Parse(Console.ReadLine());

        // if (procesador == 1 && memoria == 1)
        //     precio = 800;
        // else if (procesador == 1 && memoria == 2)
        //     precio = 900;

        // if(procesador == 1)
        // {
        //     if(memoria == 1)
        //         precio = 800;
        //     else if(memoria == 2)
        //         precio = 900;
        //     else   
        //         precio = 1000;
        // }
        if(procesador == 1)
        {
            switch (memoria)
            {
                case 1:
                    precio = 800;
                    break;
                case 2:
                    precio = 900;
                    break;
                default:
                    precio = 1000;
                    break;
            }
        }
        if(procesador == 2)
        {
            switch (memoria)
            {
                case 1:
                    precio = 900;
                    break;
                case 2:
                    precio = 1000;
                    break;
                default:
                    precio = 1200;
                    break;
            }
        }
        if(procesador == 3)
        {
            switch (memoria)
            {
                case 1:
                    precio = 1200;
                    break;
                case 2:
                    precio = 1400;
                    break;
                default:
                    precio = 2000;
                    break;
            }
        }

        if(disco == 1)
            precio = precio + 300;

        
        
        Console.WriteLine("El precio final es de: " + precio + " Pesos");
    }
}
