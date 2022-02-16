using System;
using Method;
    
namespace Method {    
    
    class Program 
    {
        static void Main (string [] args) 
        {

        method op = new method();
        
            int valorprocurado = 5;
            int [] array = new int [10] {1,2,3,4,5,6,7,8,9,10};
        
        bool Existe = op.Finder(array, valorprocurado);

            if (Existe == true) 
            {
                System.Console.WriteLine($"Valor {valorprocurado} encontrado.");
            }

            else
            {
                System.Console.WriteLine($"Valor {valorprocurado} não encontrado.");
            }
        }
    }
}
