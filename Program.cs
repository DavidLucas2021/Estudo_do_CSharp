using System;

public class Sistema
{
    static void Main()
    {
        Carro c1 = new Carro("sim");
        Console.WriteLine("Portas fechadas: " + c1.portasfechada);
        Console.WriteLine("Chave: " + c1.GetChave());
        Console.WriteLine("Ligado: " + c1.ligar());
        Console.WriteLine("Velocidade: " + c1.velocidade);

        CarroGrande cg1 = new CarroGrande();
        Console.WriteLine("Portas: " + cg1.portas);
        Console.WriteLine("Portas fechadas: " + cg1.portasfechada);
        Console.WriteLine("Chave: " + cg1.GetChave());
        Console.WriteLine("Ligado: " + cg1.ligar());
        Console.WriteLine("Velocidade: " + cg1.velocidade);

    }
}
public class Veiculo //Classe Base
{
    public int velocidade;
    public bool ligado;
    private string chave;

    public string portasfechada;

    public string ligar()
    {
        if (velocidade > 0 && GetChave() == "sim")
        {
            ligado = true;
            return "sim";
        }
        else
        {
            ligado = false;
            return "não";
        }
    }
    public Veiculo()
    {
        string chave;
        chave = Console.ReadLine();
        Console.Clear();
        this.chave = chave;
    }
    public string GetChave()
    {
        return chave;
    }
}
public class Carro : Veiculo  //Classe Carro = Classe Derivada(filha) 
{
    public Carro(string fechado) : base()
    {
        portasfechada = fechado;
        velocidade = int.Parse(Console.ReadLine());
        Console.Clear();
    }
}
public class CarroGrande : Carro
{
    public int portas;
    public CarroGrande() : base("sim")
    { 
        portas=6;
    }
}


