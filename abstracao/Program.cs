using System;
using modelos;

    namespace method {

        class cadastro 
        {
            static void Main (string [] args) 
            {                
            
            Pessoa p1 = new Pessoa(); // Cria um objeto p1 do tipo Pessoa
            
            p1.Nome = "Lucas";
            p1.Idade = 20;

            p1.Apresentar();

        }
    }
}

