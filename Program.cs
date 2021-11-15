using System;

public class Principal
{
    static void Main(string[] args)
    {
        if(args.Length > 0 )
        {
            Console.WriteLine("Quantidade de argumentos: "+args.Length);
            foreach(string arg in args)
            {
                Console.WriteLine("Argumento: " +arg);
            }
        }
        else
        {
            Console.WriteLine("Não foram passados argumentos.");
        }
    }
}