using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter age: ");
            //string age = Console.ReadLine();
            //Console.Write("Enter residence: ");
            //string residence = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " you are " + age + " and you are from " + residence);

            //int num = "45";
            //Console.WriteLine("43" + "56");

            //Console.ReadLine();

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);

            //Console.ReadLine();

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //int[] luckyNumbers = { 3,5,56,78,9,8,0 };
            //string[] friends = new string[5];
            //friends[0] = "Jane";
            //friends[1] = "Joey";

            //luckyNumbers[1] = 900;

            //Console.WriteLine( luckyNumbers[1] );

            //Console.ReadLine();

            //SayHi("Ben", 34);
            //SayHi("John", 13);
            //SayHi("Jenny", 1000);
            //Console.ReadLine();


            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }

        static double cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age + " years old ");
        //}
    }
}
