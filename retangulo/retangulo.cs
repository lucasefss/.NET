namespace ret {
    public class retangulo {

        private int comprimento;
        private int largura;

        public void DefinirMedidas(int comprimento, int largura){

            this.comprimento = comprimento;
            this.largura = largura;
        }

        public double ObterArea() 
        {
            return comprimento * largura;
        }
    }
}