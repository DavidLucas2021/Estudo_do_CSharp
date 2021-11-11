using System;

public class Principal
{
    static void Main()
    {
        double vpi=Calculo.pi;
        Console.WriteLine(vpi);
        Console.WriteLine(Calculo.dobro(10));
    }
    public class Calculo
    {
        public static double pi=3.14;

        public static int dobro(int n)
        {
            return 2*n;
        }
    }
}