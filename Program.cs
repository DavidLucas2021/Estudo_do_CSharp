using System;

public class Principal
{
    static void Main()
    {
        Galinha Galinha1 = new Galinha("Juricimeia");
        Galinha Galinha2 = new Galinha("Chicamelia");
        Galinha Galinha3 = new Galinha("Juriscleideneia");
        Galinha1.Botar();
        Galinha1.Botar();
        Galinha1.Botar();
        Console.Clear(); 
        Galinha1.Botar();
        Galinha2.Botar();
        Galinha3.Botar();
    }
}
public class Galinha
{
    private string nome;
    private int n_ovo;
    public Galinha(string nome)
    {
        this.nome=nome;
        n_ovo=0;
    }
     public Ovo Botar()
     {
        n_ovo++; 
        return new Ovo(n_ovo,nome);
     } 
}
public class Ovo
{
    private int n_ovo;
    private string nome;
    public Ovo(int n_ovo,string nome)
    {
        this.nome=nome;
        this.n_ovo=n_ovo;
        Console.WriteLine("Foi formado " +this.n_ovo +" ovo(s) - " +this.nome);
    }
}