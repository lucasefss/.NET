using System;
using ret;

    namespace method {

        class cadastro 
        {
            static void Main (string [] args) 
            {     

            retangulo r = new retangulo ();      
            r.DefinirMedidas(30,30);
            r.ObterArea();
            System.Console.WriteLine($"Área: {r.ObterArea()}");
            
            // Pessoa p1 = new Pessoa(); // Cria um objeto p1 do tipo Pessoa
            
            // p1.Nome = "Lucas";
            // p1.Idade = 20;

            // p1.Apresentar();

        }
    }
}