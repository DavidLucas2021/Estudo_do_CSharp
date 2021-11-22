using System;
using System.Collections.Generic;
    
    class Principal
    {
        public static void Main()
        {
            List<string> Carros = new List<string>();
            List<string> veiculos = new List<string>();

            Carros.Add("uno");
            Carros.Add("golf");
            Carros.Add("siena");
            Carros.Add("punto");

            //MÉTODO PARA LIMPAR TODA LISTA
            //Carros.Clear();

            //"Contains"=MÉTODO QUE VERIFICA SE HÁ 
            //O ELEMENTO ESPECIFICADO NA LISTA
            if(Carros.Contains("golf"))
            {
                Console.WriteLine("O ELEMENTO ESTÁ NA LISTA");
            }
            else
            {
                Console.WriteLine("O ELEMENTO NÃO ESTÁ NA LISTA"); 
            }
            foreach(string car in Carros)
            {
                Console.WriteLine(car);
            }

            // "AddRange"=MÉTODO QUE É USADO PARA ADICIONAR 
            // VÁRIOS ELEMENTOS EM UMA LISTA. NO EXEMPLO É
            // ADICIONADO OS ELEMENTOS DA LISTA "CARROS" EM "VEICULOS" 
            veiculos.AddRange(Carros);
            foreach(string veiculo in veiculos)
            {
               Console.WriteLine(veiculo);
            }

            //OUTRA FORMA DE ADICIONAR VARIOS ELEMENTOS 
            //NA LISTA É USANDO "AddRange" CARREGANDO UM 
            //ARRAY COM OS ELEMENTOS ABAIXO.
            //string[] nome_veiculos = new string[]{"celta","cobat","up","jetta","monza"};
            //veiculos.AddRange(nome_veiculos);
            //foreach(string veiculo in veiculos)
            //{
            //    Console.WriteLine(veiculo);
            //}


            //"CopyTo"=MÉTODO QUE COPIA DA LISTA "CARROS"
            //PARA O ARRAY "VEICULOS" DEPOIS DA POSIÇÃO 2.
            // Carros.CopyTo(veiculos,2);
            // foreach(string veiculo in veiculos)
            // {
            //    Console.WriteLine(veiculo);
            // }

            //"IndexOf"=MÉTODO QUE RETORNA A POSIÇÃO 
            //DO ELEMENTO ESPECIFICADO.
            String c="golf";
            int posição=0;
            posição=Carros.IndexOf(c);
            Console.WriteLine("O CARRO " +c +" ESTA NA POCIÇÃO " +posição);

        }
    }
