using System;
using System.Linq;

namespace ConsoleCompereEx
{
    class Program
    {
        const string SEP_LINE = "------------------------------------";

        static void Main(string[] args)
        {
            ExArray();
        }

        static void ExArray()
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            int[] compNumbers = new int[4]; // when you see the "new" key word, your know a new object is going to be created.
            compNumbers[0] = 1;
            compNumbers[1] = 2;
            compNumbers[2] = 3;
            compNumbers[3] = 4;
            //int[] numbers = { 1, 2, 3, 4 };
            //int[] compNumbers = { 1, 2, 3, 4 };

            Console.WriteLine("Array");

            Console.WriteLine(SEP_LINE);

            if (numbers == compNumbers)
            {
                Console.WriteLine("Compere == true");
            }
            else
            {
                Console.WriteLine("Compere == false");
            }

            Console.WriteLine(SEP_LINE);

            if (numbers.Equals(compNumbers) )
            {
                Console.WriteLine("Compere .Equals true");
            }
            else
            {
                Console.WriteLine("Compere .Equals false");
            }

            Console.WriteLine(SEP_LINE);

            //needs to have the following at the top of the code file: using System.Linq;
            if (numbers.SequenceEqual(compNumbers))
            {
                Console.WriteLine("Compere .SequenceEqual true");
            }
            else
            {
                Console.WriteLine("Compere .SequenceEqual false");
            }

            /*
                The reson behind this problem to compere arrays is becouse of it´s a array object.
                The content of them might be the same but thay are two diffrent Objects.
            */
        }
    }
}
