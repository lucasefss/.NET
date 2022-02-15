using System;

namespace exemplo
{
    public class operacoesarray 
    {
        public void OrganizarArray(ref int [] array)
        {
            Array.Sort(array);
        }

        public void imprimirarray(int [] array) 
        {
            // for (int i = 0; i < array.Length; i++)
            // {
            //     System.Console.WriteLine(array[i]);  
            // }

            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }
    }
}
