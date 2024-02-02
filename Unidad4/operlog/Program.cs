namespace operlog;

class Program
{
    static void Main(string[] args)
    {
        //operador AND --> && <--- [Y]
        //operador OR -->|| <--- [O]

        int edad = 30;
        char inicial = "J";

        if(edad > 30 && inicial == "H")
        {
            Console.WriteLine("25 % OFF...");
        }

        if(edad > 30 || inicial == "H")
        {
            Console.WriteLine("30 % OFF...");
        }
        Console.WriteLine("Fin Programa");
        //OR
        //true || false = true
        //false || true = true
        //true || true = true
        //false || false = false

        //AND
        //true && true = true
        //false && true = false
        //true && false = false
        //false && false = false
    }
}
