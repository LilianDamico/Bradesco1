// Inicio

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class MetodosEstaticos
{
    public static int somar (int x, int y)
    {
        return x + y;
    }
    public int multiplicar (int x, int y)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        var result = MetodosEstaticos.somar(3, 10);
        Console.WriteLine("A soma é igual a: {0}", result);

        MetodosEstaticos calc = new MetodosEstaticos();
        Console.WriteLine(calc.multiplicar(3, 40));
    }
    
}
