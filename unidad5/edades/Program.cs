namespace edades;

class Program
{
    static void Main(string[] args)
    {
        int e, con = 0, acum = 0, promedio;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero:");
            e = int.Parse(Console.ReadLine());
            if(e > 18)
            {
                acum += e;
                con ++;
            }
        }
            promedio = acum / con;

            Console.WriteLine("El promedio de edades es: " + promedio);
    }
}
