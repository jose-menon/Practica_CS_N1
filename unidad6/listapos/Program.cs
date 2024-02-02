namespace listapos;

class Program
{
    static void Main(string[] args)
    {
        int n, con, numeroGrupo = 0;
        do
        {
            numeroGrupo++;
            con = 0;
            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                con++;
                Console.WriteLine("ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("la cantidad del grupo " + numeroGrupo + " es " + con);
        }
        while (n >= 0);
    }
}
