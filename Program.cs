using System;
using System.Collections.Generic;
    
    class Principal
    {
        public static void Main()
        {
            LinkedList<string> Carros = new LinkedList<string>();

            //"AddFirst"=MÉTODO QUE ADICIONA NO COMEÇO DA LISTA 
            Carros.AddFirst("camaro");
            Carros.AddFirst("mustang");
            Carros.AddFirst("porshe");
            Carros.AddFirst("lamborghini");

            //"AddLast"=MÉTODO QUE ADICIONA NO FIM DA LISTA
            Carros.AddLast("skyline");

            //"AddAfter"=ADICIONA APÓS UM DETERMINADO ELEMENTO
            //"LinkedListNode"=CRIA UM NÓ NA LISTA 
            //"FindLast"=ENCONTRA A ÚLTIMA POSIÇÃO DO ELEMENTO 
            LinkedListNode<string>no;
            no=Carros.FindLast("porshe");
            //USANDO O "Next", "porshe 911" É ADICIONADO APÓS O PRÓXIMO A "porshe"
            //QUE É O "mustang". TAMBÉM PODE SER USANDO O "Previous" PARA ADICIONAR 
            //APÓS O ANTERIOR A "porshe" QUE É O "corvette"
            Carros.AddAfter(no,"porshe 911");

            //"AddAfter"=ADICIONA ANTES DE UM DETERMINADO ELEMENTO
            //"FindLast"=ENCONTRA A ÚLTIMA POSIÇÃO DO ELEMENTO
            no=Carros.FindLast("porshe");
            Carros.AddBefore(no,"corvette");

            //MÉTODO PARA LIMPAR TODA A LISTA 
            //Carros.Clear();

            //MÉTODO QUE REMOVE UM ELEMENTO DA LISTA
            //Carros.Remove("camaro");

            //MÉTODO QUE REMOVE O PRIMEIRO ELEMENTO DA LISTA 
            //Carros.RemoveFirst();

            //MÉTODO QUE REMOVE O ÚLTIMO ELEMENTO DA LISTA 
            //Carros.RemoveLast();

            //"Find"=PROCURA UM ELEMENTO NA LISTA 
            if(Carros.Find("corvette")!=null)
            {
                Console.WriteLine("O ELEMENTO FOI ENCONTRADO NA LISTA");
            }
            else
            {
                Console.WriteLine("O ELEMENTO NÃO FOI ENCONTRADO NA LISTA");
            }


            foreach(string car in Carros)
            {
                Console.WriteLine(car);
            }
        }
    }
