namespace vectordoble;

class Program
{
    static void Main(string[] args)
    {
        double[] muestraMatutina = new double[31];
        double[] muestraVespertina = new double[31];
        double[] muestraNocturna = new double[31];

        int dia;
        double temperatura;
        Console.WriteLine("Carge el registro matutino:");
        for (int x = 0; x < 31; x++)
        {
            Console.WriteLine("ingrese el dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese temperatura:");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia - 1] = temperatura;
        }

        double acu = 0;
        for (int x = 0; x < 31; x++)
        {
            acu += muestraMatutina[x];
        }
    }
}
