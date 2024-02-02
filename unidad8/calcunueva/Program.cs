namespace calcunueva;

class Program
{
    static void Main(string[] args)
    {
        //paso 0 
        //tipo de dato: int, float, char, bool
        int n1 = 0, n2 = 0, resultado;
        //int n2;
        pedirDatos(ref n1, ref n2);
        //paso 2 realizar calculo
        // resultado = n1 + n2;
        resultado = sumar(n1, n2);

        //paso 3 mostrar resultado
        Console.WriteLine("El resultado es " + resultado);      
    }
    METODO DE INGRESO DE PARAMETROS POR VALOR
    static int sumar(int a, int b)
    {
        int r;
        r = a + b;
        return r;
    }

    //METODO DE INGRESO DE PARAMETROS POR REFERENCIA
    static void pedirDatos(ref int j, ref int h)
    {
        //paso 1 pedir valores
        Console.WriteLine("Ingrese un numero: ");
        j = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        h = int.Parse(Console.ReadLine());
    }
}
