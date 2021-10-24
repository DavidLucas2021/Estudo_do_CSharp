using System;

public class Principal
{
    static void Main()
    {
        Derivada2 d2 = new Derivada2();
    }
}
public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor Base");
    }
}
public class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }
}
public class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }
}