using System;

public class Principal
{
    static void Main()
    {
        int n1,n2,resultado;
        resultado=n1=n2=0;
        n1=10;
        n2=0;

        try
        {
        resultado=n1/n2;//No momento que o bloco Try identifica o erro,ele para
        //de executar seu trecho e pula para o Catch. Neste caso, ele não imprime a operação
        Console.WriteLine("{0}/{1}={2}",n1,n2,resultado);
        }
        catch(Exception e)//"Exception" é a classe que informa o erro, "e" objeto da classe.
        {
            Console.WriteLine("Erro: " +e.Message);
            Console.WriteLine("Exceção: " +e.GetType());
        }
    }
}