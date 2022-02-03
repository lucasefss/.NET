using System;

namespace modelos {

   public class Pessoa {

       public string Nome { get; set; }
       public int Idade { get; set; }

       public void Apresentar () {

           Console.WriteLine($"O nome é {Nome} e têm {Idade} anos de idade");

        }
   }
}