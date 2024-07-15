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
            //type_A type_a = new type_A(5);
            //type_a.A = 10;
            //type_a.Fun_1();
            //type_a.Fun_2();
            //type_a.Fun_3();

            //Console.WriteLine("-----------------------");

            //type_B type_b = new type_B(5,10);
            //type_b.A = 8;
            //type_b.B = 17;
            //type_b.Fun_1();
            //type_b.Fun_2();
            //type_b.Fun_3();
            #endregion

            #region binding
            type_A type_a = new type_A(5);
            type_a.A = 10;
            type_a.Fun_1();
            type_a.Fun_2();
            type_a.Fun_3();

            Console.WriteLine("-----------------------");

            type_B type_b = new type_B(5, 10);
            type_b.A = 8;
            type_b.B = 17;
            type_b.Fun_1();
            type_b.Fun_2();
            type_b.Fun_3();

            Console.WriteLine("-----------------------");

            type_C type_c = new type_C(5, 10, 15);
            type_c.A = 8;
            type_c.B = 17;
            type_c.C = 23;
            type_c.Fun_1();
            type_c.Fun_2();
            type_c.Fun_3();

            Console.WriteLine("-----------------------");

            type_D type_d = new type_D(5, 10, 15, 20);
            type_d.A = 8;
            type_d.B = 17;
            type_d.C = 23;
            type_d.D = 23;
            type_d.Fun_1();
            type_d.Fun_2();
            type_d.Fun_3();
            #endregion


        }

        #region polymorphism via overloading
        //static void multiply(int number_1, int number_2)
        //{
        //    Console.WriteLine($"{number_1} * {number_2} = {number_1 * number_2}");
        //}

        //static void multiply(int number_1, int number_2, int number_3)
        //{
        //    Console.WriteLine($"{number_1} * {number_2} * {number_3} = {number_1 * number_2 * number_3}");
        //}

        //static void multiply(int number_1, int number_2, int number_3, int number_4)
        //{
        //    Console.WriteLine($"{number_1} * {number_2} * {number_3} * {number_4} = {number_1 * number_2 * number_3 * number_4}");
        //}
        #endregion
    }
}