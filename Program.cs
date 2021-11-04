using System;

public class Principal
{
    static void Main()
    {      
        Carro Uno;
        Uno.marca="Fiat";
        Uno.modelo="Uno Way";
        Uno.cor="Vermelho";
        Uno.info();

        Carro[] Mobi = new Carro[5];
        Mobi[0].marca="Fiat";
        Mobi[0].modelo="Mobi basico";
        Mobi[0].cor="Lilaz";

        Mobi[1].marca="Fiat";
        Mobi[1].modelo="Mobi compacto";
        Mobi[1].cor="azul";

        Mobi[2].marca="Fiat";
        Mobi[2].modelo="Mobi sedan";
        Mobi[2].cor="Verde";

        Mobi[3].marca="Fiat";
        Mobi[3].modelo="Mobi turbo";
        Mobi[3].cor="Amarelo";

        Mobi[4].marca="Fiat";
        Mobi[4].modelo="Mobi luxo";
        Mobi[4].cor="Black";

        //O MÉTODO  PODE SER CHAMADO INFORMANDO A POSIÇÃO DO ARRAAY(UM DE CADA VEZ)
        
        // Mobi[0].info();
        // Mobi[1].info();
        // Mobi[2].info();
        // Mobi[3].info();
        // Mobi[4].info();

        //OU PODE SER USADO O FOR PARA CHAMR O MÉTODO

        for(int i=0;i<Mobi.Length;i++)
        {
            Mobi[i].info();
        }
    }
}
struct Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public void info()
    {
        Console.WriteLine("Marca do carro............."+ this.marca);
        Console.WriteLine("Marca do carro............."+ this.modelo);
        Console.WriteLine("Marca do carro............."+ this.cor);
        Console.WriteLine("____________________________________________");
    }
}