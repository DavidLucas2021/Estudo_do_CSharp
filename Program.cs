using System;

public class Principal
{
    static void Main()
    {   
        Carro Uno = new Carro();
        Uno.vm=340;
        Console.WriteLine("Velocidade Máxima:...."+Uno.vm);        
    }
}
class Carro
{
    private int Vel_Max;
    public Carro()
    {
        vm=120;
    }
    public int vm{
        get
        {
            return Vel_Max;
        }
        set
        {
            if(value < 0)
            {
                Vel_Max=0;
            }else if(value > 300)
            {
                Vel_Max=300;
            }else
            {
                Vel_Max=value;
            }
        }
    }
}