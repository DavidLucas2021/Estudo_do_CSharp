using System;

public class Principal
{
    static void Main()
    {
        Derivada2 d2 = new Derivada2();
        d2.informacao();
    }
}
public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor Base");
    }
    virtual public void informacao(){}
}

public class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }
    override public void informacao()
    {
        Console.WriteLine("Método virtual da classe Base na classe Drivada 1");
    }
}

public class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }
}