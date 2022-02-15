using System;

    namespace exemplo 
    {
        class exemplo2 
        {
            
            static void Main (string [] args) 
            {
                operacoesarray op = new operacoesarray();
            
                int [] array = new int [5] {5,7,8,4,1};
            
                op.OrganizarArray(ref array);
           
                op.imprimirarray(array);
            }
            
            
        }
    }
