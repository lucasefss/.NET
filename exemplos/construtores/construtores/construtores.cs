using System; 

namespace construtores 
{
        
    public class Pessoa 
    {

        public string? Nome;
        public string? Sobrenome;

        public Pessoa () // Os construtores PRECISAM ter o mesmo nome da classe.
        {
            Nome = string.Empty;
            Sobrenome = string.Empty;
        }

        public Pessoa (string Nome, string Sobrenome) 
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}");
        }

    }
}