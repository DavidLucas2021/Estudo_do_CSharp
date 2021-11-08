using System;

public class Principal
{
    static void Main()
    {
        Calculadora Calculadora = new Calculadora();
        var resultado=Calculadora.soma(10.5,10);
        Console.WriteLine(resultado);
    }
}
class Calculadora
{
    public int soma(params int[] num)
    {
        int res=0;

        for(int i=0;i<num.Length;i++)
        {
            res += num[i];
        }
        return res;        
    }
     public double soma(params double[] num)
    {
        double res=0;

        for(int i=0;i<num.Length;i++)
        {
            res += num[i];
        }   
        return res;     
    }
}