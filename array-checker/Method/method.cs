namespace Method
{
    public class method
    {
        public bool Finder(int [] array, int valorprocurado)
        {
            return Array.Exists(array, elemento => elemento == valorprocurado); 
        }
    }
}