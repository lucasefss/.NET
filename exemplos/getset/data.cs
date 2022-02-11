namespace getset 
{
    public class time 
    {
        public int var1;
        
        public void teste() 
        {
            System.Console.WriteLine("Insira aqui o algarismo desejado: ");
        }
        // public string? parametro;

        // public string? GetTime()
        // {
        //     Convert.ToString(var1);
        //     return this.var1;
        // }

        public void SetTime(int var1)
        {
            System.Console.WriteLine("Insira aqui o algarismo desejado: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            
            switch (var1)
            {
                case 1:
                    System.Console.WriteLine("Fluminense Football Club"); 
                break;
                case 2:
                    System.Console.WriteLine("Vasco da Gama");
                break;
                case 3: 
                    System.Console.WriteLine("É proibido remar");
                break;
                case 4:
                    System.Console.WriteLine("América Football Club");
                break;
            }
        }
    }
}