namespace program {

    public class cadastro {

        public static void Main (string [] args) 
        {            
            
            Console.WriteLine();
            Console.WriteLine("Aqui está a lista de livros cadastrados: ");
            Console.WriteLine();

            dados livro1 = new dados();
            livro1.Nome = "As Veias Abertas da América Latina";
            livro1.CDD = 322.81;
            livro1.Autor = "Galeano, Eduardo";
            livro1.Apresentar();
            Console.WriteLine();

            dados livro2 = new dados();
            livro2.Nome = "Quarto de Despejo";
            livro2.CDD = 981;
            livro2.Autor = "Jesus, Carolina Maria de";
            livro2.Apresentar();
            Console.WriteLine();

            
        }
    }
}