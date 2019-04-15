using System;


namespace Exercise._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string  question = "Enter Number between 1 to 10:";
            Console.WriteLine(question);
            int number = 5;
            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }


        }
    }
}
