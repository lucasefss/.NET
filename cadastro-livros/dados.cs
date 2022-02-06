namespace program {

    class dados {

        public string? Nome { get; set; }
        public double CDD { get; set; }
        public string? Autor { get; set; }
        
        public void Apresentar() {
        System.Console.WriteLine($"Livro: {Nome} - Classificação {CDD} - Autor {Autor}");
       }
    }        
}