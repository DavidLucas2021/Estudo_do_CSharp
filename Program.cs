using System;
using System.Collections.Generic;
    
    class Principal
    {
        public static void Main()
        {
            //string[] nomes= new string[5]{"camaro","civic","cruce","corvette","jetta"};
            //QUEUE:PRIMEIRO ELEMENTO A ENTRAR, PRIMEIRO ELEMENTO A SAIR 
            Queue<string> veiculo = new Queue<string>(/*nomes*/);
            
            //MÉTODO QUE ADICIONA ELEMENTO NO FINAL DA FILA
            veiculo.Enqueue("camaro");
            veiculo.Enqueue("civic");
            veiculo.Enqueue("cruce");
            veiculo.Enqueue("corvette");
            veiculo.Enqueue("jetta");

            //"Clear":LIMPA TODO A FILA 
            //veiculo.Clear();

            //"Dequeue":RETORNA O PRIMEIRO ELEMENTO DA FILA E DEPOIS O REMOVE
            Console.WriteLine("Primeiro elemento da fila:" + veiculo.Dequeue());

            //REMOVE O PRIMEIRO ELEMENTO DA FILA
            //veiculo.Dequeue();

            //SOMENTE RETORNA O ELEMENTO DA FILA 
            Console.WriteLine("Primeiro elemento da fila:" + veiculo.Peek());

            //"Count":RETORNA UM INT COM A QUANTIDADE DE ITENS DA FILA
            System.Console.WriteLine("Tamanho da Fila: "+veiculo.Count);
            System.Console.WriteLine("Itens da Fila:");
            
            foreach(string car in veiculo)
            {
                System.Console.WriteLine(car);
            }

            string c="jetta";
            //"Contains":MÉTODO QUE VERIFICA SE HÁ O ELEMENTO ESPECIFICADO NA FILA 
            if(veiculo.Contains(c))
            {
                System.Console.WriteLine("O item " +c +" está na fila.");
            }
            else
            {
                System.Console.WriteLine("O item " +c +" não está na fila.");
            }


        }
    }
