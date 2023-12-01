namespace Factorial_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial_recursivo(5));
        }

        static int Factorial_recursivo(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial_recursivo(num-1);
            }
        }
    }
}