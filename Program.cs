using System;
using System.Collections.Generic;
    
    class Principal
    {
        public static void Main()
        {
         Dictionary <int,string> veiculos = new Dictionary<int, string>();
            //"add"=MÉTODO QUE ADICIONA VALORES NO DICIONÁRIO COM A CHAVE CERTA
            veiculos.Add( 0,"uno"); 
            veiculos.Add( 2,"doblo");
            veiculos.Add(10,"strada");
            veiculos.Add(12,"camaro");
            
            //"Remove"=MÉTODO QUE REMOVE UM ITEM DO DICIONÁRIO 
            //veiculos.Remove(8);

            //"Clear"=MÉTODO QUE REMOVE TODOS OS ITENS DO DICIONÁRIO
            //veiculos.Clear();

            //NESTE TRECHO DO CÓDIGO É VERIFICADO SE HÁ A CHAVE ESPECIFICADA
            //ATRAVÉS DA VARIÁVEL "chave" e do MÉTODO "ContainsKey" QUE 
            //RETORNA TRUE QUANDO ACHA A CHAVE.
            int chave=2;
            Console.WriteLine("Tamanho do Dictionary: "+veiculos.Count);
            if(veiculos.ContainsKey(chave))
            {
                Console.WriteLine("A chave " +chave +" esta na coleção");
            }
            else
            {
                Console.WriteLine("A chave " +chave +" não esta na coleção");
            }

            //NESTE TRECHO DO CÓDIGO É VERIFICADO SE HÁ O VALOR ESPECIFICADA
            //ATRAVÉS DA VARIÁVEL "valor" e do MÉTODO "ContainsValue" QUE 
            //RETORNA TRUE QUANDO ACHA O VALOR.
            string valor="camaro";
            if(veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor '" +valor +"' esta na coleção");
            }
            else
            {
                Console.WriteLine("O valor '" +valor +"' não esta na coleção");
            }
            
            //NESTE TRECHO DO CÓDIGO O VALOR DA PRIMEIRA POSIÇÃO É 
            //ALTERADO ATRAVÉS DE "veiculo[0]" SUBSTITUINDO O ANTIGO
            //VALOR "uno".
            veiculos[0]="argo"; //SUBSTITUIÇÃO DO VALOR="uno" PARA O VALOR="bravo"
            valor="argo";
            if(veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor '" +valor +"' esta na coleção");
            }
            else
            {
                Console.WriteLine("O valor '" +valor +"' não esta na coleção");
            }
            //NESTE TRECHO DO CÓDIGO É FEITA A IMPRESSÃO DO ITENS
            //DO DICIONÁRIO ATRAVÉS DO FOREACH USANDO O 
            //"keiValuePair<chave,valor>" QUE DETERMINA "s" 
            //NÃO COMO UMA VARIÁVEIL INT OU STRING, MAS COMO UMA INSTÂNCIA
            //DO DICIONÁRIO. ASSIM É POSSÍVEL CHAMAS "s" COM 
            //VALOR("value") OU CHAVE("key").
            //foreach(KeyValuePair<int,string> s in veiculos)
            //{
            //    Console.WriteLine(s.Value);
            //}
            
            //OUTRA FORMA DE IMPRIMIR TODOS OS ITENS DO DICIONÁRIO
            //É USANDO O "Dictionary<int,string>.ValueColletion"
            //ONDE É CRIADO UM DICIONÁRIO CHAMADO "valores" QUE RECEBE
            //VALOR DO DICIONÁRIO "veiculo".
            Dictionary<int,string>.ValueCollection valores=veiculos.Values;
            
            foreach(string s in veiculos)
            {
                Console.WriteLine(s);
            }
            
        }
    }
