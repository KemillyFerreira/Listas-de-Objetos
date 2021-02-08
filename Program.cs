using System;
using System.Collections.Generic;

namespace Lista_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> nomes = new List<string>();
            nomes.Add("Carlos");
            nomes.Add("José");
            nomes.Add("Ronaldo");
            nomes.Add("Chintia");
            nomes.Add("Maria");

            //Constains => identifica o item na lista
            bool resposta = nomes.Contains("Dudu");

            if(resposta == true)
            {
                Console.WriteLine("Nome enontrado");
            }else{
                Console.WriteLine("Nome não encontrado");
            }

            //Count => conta quantos itens há na lista
            Console.WriteLine(nomes.Count);

            //Insert => insere uma informação solicitada, em tal lugar
            for (var i = 0; i < nomes.Count; i++)
            {
                if(nomes[i] == "Ronaldo")
                {
                    nomes.Insert(i, "Ronaldinho");
                }
            }

            //Remove => remove algo da lista
            nomes.Remove("Ronaldo");

            //Sort => ordena a lista
            nomes.Sort();*/

            List<Produto> produtos = new List<Produto>();

            Produto cafe = new Produto (2, " Café pequeno", 2.5f);
            produtos.Add(new Produto(1, " Pão na chapa", 5.0f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, " Coxinha", 5.0f));
            produtos.Add(new Produto(4, "Refrigerante", 6.8f));

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"item codigo{item.Codigo} Nome{item.Nome} Preço{item.Preco}");
            }
        }
    }
}