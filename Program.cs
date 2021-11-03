using System;

public class Principal
{
    static void Main()
    {   
        Uno Unoway = new Uno();
        Console.WriteLine(Unoway.Getinformar());
        Console.WriteLine(Unoway.Getaceleracao());        
    }
}

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}
public interface Carro
{
    void acelerar();
}

public class Uno:Veiculo,Carro
{
    public bool ligado;
    public int aceleracao;
    public string informar;
    public Uno()
    {
    }
    public void ligar()
    {
        this.ligado=true;
    }
    public void desligar()
    {
        this.ligado=false;
    }
    public void info()
    {       
        this.informar="LIGADO";
    }
    public void acelerar()
    {
        this.aceleracao=100;
    }
    public string Getinformar()
    {
        return informar;
    }
    public int Getaceleracao()
    {
        return aceleracao;
    }
}