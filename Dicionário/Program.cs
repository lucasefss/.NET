using System;

namespace exemplo 
{
        class Dicionario 
        {

            static void Main (string [] args) 
            {
            
            Dictionary<string, string> clubes = new Dictionary<string, string>();

            clubes.Add("1", "Fluminense Football Club");
            clubes.Add("2", "Botafogo de Futebol e Regatas");
            clubes.Add("3","Clube de de Regatas do Flamengo");
            clubes.Add("4", "Clube de Regatas Vasco da Gama");

            System.Console.WriteLine("Lista de clubes cadastrados: ");
            System.Console.WriteLine();

            foreach (KeyValuePair<string, string> item in clubes)
            {
                System.Console.WriteLine($"Clube número {item.Key}: {item.Value}");
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Insira o clube procurado utilizando a chave requerida: ");
            var valorprocurado = Console.ReadLine();

            System.Console.WriteLine(clubes[valorprocurado]);

        }
    }
}