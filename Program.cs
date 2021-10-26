using System;

public class Principal
{
    static void Main()
    {
        Carro Argo  = new Carro();
        Argo.aceleração(5);
        Console.WriteLine("ligado;.............."+Argo.GetLigado(true));
        Console.WriteLine("Velocidade Atual:...."+Argo.GetVel_Atual());
        Console.WriteLine("Velocidade Atual:...."+Argo.GetVel_Max());
        
        
    }
}
abstract class Veiculo
{
    protected int Vel_Max;
    protected int Vel_Atual;
    protected bool Ligado;

    public Veiculo()
    {
        Ligado=false;
        Vel_Atual=0;
    }
    public string GetLigado(bool ligado)
    {
        this.Ligado=ligado;
        if(ligado == true)
        {
            return "sim";
        }else return "não";
    }
    abstract public void aceleração(int aum);
}
class Carro:Veiculo
{
    public Carro()
    {
        Vel_Max=110;
    }
    override public void aceleração(int aumentar)
    {
        Vel_Atual+=10*aumentar;
    }
    public int GetVel_Max()
    {
        return Vel_Max;
    }
       public int GetVel_Atual()
    {
        return Vel_Atual;
    }
}