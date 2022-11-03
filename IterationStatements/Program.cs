using System.Reflection.Metadata;
using System.Text;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {

            NumOneThousand();
            NumByThrees();


            CheckParams(4, 4);

            Console.WriteLine("type in a number to see if it is even or odd");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOdd(userInput));

            Console.WriteLine("type in a number to see if it is positive or negative");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckPlusMinus(userNum));

            Console.WriteLine("What is your age to determine if you are old enough to vote?");
            int voter = int.Parse(Console.ReadLine());
            Console.WriteLine(VoteAge(voter));

            Console.WriteLine("Type in a number to see if a number is in a range");
            int sender = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckRange(sender));

            Console.WriteLine("Type in a number");
            int sender1 = int.Parse(Console.ReadLine());
            MultiplyTable(sender1);



        }
        public static void NumOneThousand()
        {
             for (int i = 1000; i >= 1000; i--)
            {
                Console.WriteLine(i);
            }
                
        }

        public static void NumByThrees()
        {
            for (int x = 3; x <= 999; x += 3)
            {
                Console.WriteLine(x);
            }
        }

        public static bool CheckParams(int a, int b)
        {
            var check = (a == b) ? true : false;
            Console.WriteLine(check);
            return check;
        }

        public static string EvenOdd(int x)
        {
            var test = (x % 2);

            if (test == 0)
                return "this is an even number!!";
            else
                return "this is an odd number!!";


        } 

        public static string CheckPlusMinus(int y)
        {
            
                if (y > 0)
                    return "This is a positive number";
                else
                    return ("This is a negative number");
        }
        public static string VoteAge(int z)
        {
                if (z >= 18)
                    return "You can vote!!";
                else 
                    return "You are too young to vote";
        }

        public static string CheckRange(int sender)
        {
            int lowerValue = -10;
            int upperValue = 10;

            if (sender >= lowerValue && sender <= upperValue)
                return $"{sender} is within the range of {lowerValue} - {upperValue}";
            else
                return $"{sender} is not within the range of {lowerValue} - {upperValue}";
        }




        public static void MultiplyTable(int number)
        {
            for (int multiplier = 1; multiplier <= 12; multiplier++)
            {
                Console.WriteLine($"{number} * {multiplier} = {number * multiplier}");
            }
           
        }  
    }
}



