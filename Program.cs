using OOP_03.overriding;

namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region polymorphism via overloading
            // multiply(5, 2, 1);
            #endregion

            #region polymorphism via overloading
                type_A type_a = new type_A(5);
                type_a.A = 10;
                type_a.Fun_1();
                type_a.Fun_2();

                Console.WriteLine("-----------------------");

                type_B type_b = new type_B(5,10);
                type_b.A = 8;
                type_b.B = 17;
                type_b.Fun_1();
                type_b.Fun_2();
            #endregion


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