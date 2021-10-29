using System;

public class Principal
{
    static void Main()
    {   
        Carro Uno = new Carro();
        //Uno[4]=299;
        Console.WriteLine("Velocidade Máxima:...."+Uno[4]);        
    }
}
class Carro
{
    private int[] Vel_Max = new int[5]{100,150,230,290,330};
    public Carro()
    {

    }
    public int this[int i]{
        get
        {
            return Vel_Max[i];
        }
        set
        {
            if(value < 0)
            {
                Vel_Max[i]=0;
            }else if(value > 300)
            {
                Vel_Max[i]=300;
            }else
            {
                Vel_Max[i]=value;
            }
        }
    }
}