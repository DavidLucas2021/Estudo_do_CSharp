using System;

public class Principal
{
    static void Main()
    {      
        Carro Uno;
        Uno.marca="Fiat";
        Uno.modelo="Uno Way";
        Uno.cor="Vermelho";
        Console.WriteLine("Marca do carro............."+ Uno.marca);
        Console.WriteLine("Marca do carro............."+ Uno.modelo);
        Console.WriteLine("Marca do carro............."+ Uno.cor);

        Carro Mobi = new Carro("Fiat","Mobi 1","Azul");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Marca do carro............."+ Mobi.marca);
        Console.WriteLine("Marca do carro............."+ Mobi.modelo);
        Console.WriteLine("Marca do carro............."+ Mobi.cor);

        
    }
}
struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca,string modelo,string cor)
    {
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }
}