using System;

delegate int Op(int n1, int n2);
public class Principal
{
    static void Main()
    {
        int resultado;
        //Delegate abaixo só precisa ser definido uma vez no código.
        Op delegate1 = new Op(Calculo.soma); //Pelo motivo da classe não ser static
        resultado = delegate1(10, 10);         //é necessário fazer a chamada da classe
        Console.WriteLine("Método soma entrega " + resultado); //"Calculo" para chamar o método.

        delegate1 = new Op(Calculo.mult);
        resultado = delegate1(10, 15);
        Console.WriteLine("Método multiplicação entrega " + resultado);
    }
}
public class Calculo
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int mult(int n1, int n2)
    {
        return n1 * n2;
    }
}