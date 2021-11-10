using System;

public class Principal
{
    static void Main()
    {
        Calculadora Calculadora = new Calculadora();
        var resultado=Calculadora.fatorial(5);
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
    //RECURSIVIDADE=MÉTODO QUE CHAMA ELE MESMO.
    //FATORIAL = 5! = 5*4*3*2*1 = 120
    public int fatorial(int n)
    {
        int res;

        if(n<1)
        {
            res=1;
        }
        else    
        {
            //FATORIAL = UM NÚMERO VEZES O ANTERIOR A ELE
            res=n*fatorial(n - 1);
        }
        return res;
    }
}