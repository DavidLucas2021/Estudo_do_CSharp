using System;

public class Principal
{
    static void Main()
    {
        double area = 0;

        try
        {
            area = Area.Quad(10, 10);
            Console.WriteLine("Area do Quadrado: " +area);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: " + e.Message);
            Console.WriteLine("Exceção: " + e.GetType());
        }
        finally
        {
            Console.WriteLine("Fim do processo.");
        }
    }
}
class Area
{
    public static double Quad(double bas, double alt)
    {
        if (bas == 0 || alt == 0)
        {
            throw new Exception("Base ou Altura não podem ser igual a 0.");
        }
        else
        {
        return bas * alt;
        }
    }
}