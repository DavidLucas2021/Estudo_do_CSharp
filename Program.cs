using System;

public class Principal
{
    static void Main()
    {
        Carro Uno = new Carro("Uno Way",130);
        Console.WriteLine("Nome:................"+Uno.nome);
        Console.WriteLine("Esta ligado:........."+Uno.GetLigado());
        Console.WriteLine("Velocidade atual:...."+Uno.Vel_Atual);
        Console.WriteLine("Velocidade Máxima:..."+Uno.GetVel_Max());
    }
}
public class Program //Classe Base
{
    public int Vel_Atual;
    private int Vel_Max;
    protected bool ligado;

    public Veiculo(int Vel_Max)
    {
        Vel_Atual=0;
        this.Vel_Max=Vel_Max;
        ligado=false;  
    }
    public bool GetLigado()
    {
        return ligado;
    }
    public int GetVel_Max()
    {
        return Vel_Max;
    }

}
public class Carro : Veiculo //Classe derivada
{
    public string nome;
    public Carro(string nome, int Vel_M):base(Vel_M) 
    {
        this.nome=nome;
        ligado=true;
        Vel_Atual=30;
    }
}


