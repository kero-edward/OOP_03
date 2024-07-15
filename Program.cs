namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// 
            multiply(5, 2, 1);

            
        }

        #region polymorphism via overloading
        static void multiply(int number_1, int number_2)
        {
            Console.WriteLine($"{number_1} * {number_2} = {number_1 * number_2}");
        }

        static void multiply(int number_1, int number_2, int number_3)
        {
            Console.WriteLine($"{number_1} * {number_2} * {number_3} = {number_1 * number_2 * number_3}");
        }

        static void multiply(int number_1, int number_2, int number_3, int number_4)
        {
            Console.WriteLine($"{number_1} * {number_2} * {number_3} * {number_4} = {number_1 * number_2 * number_3 * number_4}");
        }
        #endregion
    }
}