using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Benton";
            int characterAge = 37;

            Console.WriteLine("My name is " + characterName);
            Console.WriteLine("I am " + characterAge + " years old");
            Console.WriteLine("It's almost my birthday");
            Console.WriteLine("and on August 3");

            characterAge = 38;

            Console.WriteLine("I will be " + characterAge);
            Console.WriteLine("but my name will still be " + characterName);

            string phrase = "Bicycle Academy" +" is sweet";
            char grade = 'C';
            int age = -50;
            double gpa = 12.20;
            bool isMale = true; 

            Console.WriteLine("I earned a " + grade);
            Console.WriteLine(phrase.Length);

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("sweet"));
            Console.WriteLine(phrase.Contains("skiing"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase[8]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf(" "));
            Console.WriteLine(phrase.IndexOf("z"));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));











            Console.ReadLine();
        }
    }
}
