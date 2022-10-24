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

            int sender = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckRange(sender));

            Console.WriteLine(MultiplyTable(2, 3));



        }
        public static void NumOneThousand()
        {
            for (int i = 1000; i >= 1000; i--)

                Console.WriteLine(i);
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
            string oddEven;
            {
                if (test == 0)
                    oddEven = "this is an even number!!";
                else
                    oddEven = "this is an odd number!!";
                return oddEven;

            }


        }

        public static string CheckPlusMinus(int y)
        {
            string negPos;
            {
                if (y > 0)
                    negPos = ("This is a positive number");
                else
                    negPos = ("This is a negative number");
            
                return negPos;
            }
        }
        public static string VoteAge(int z)
        {
            string voter;
            {
                if (z >= 18)
                    voter = ("You can vote!!");
                else 
                    voter = ("You are too young to vote");
                return voter;
            }
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

        

       
        public static string MultiplyTable(int d, int e)
        {
            int number, multiplier;
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
                StringBuilder sb = new();
            
            for (multiplier = 1; multiplier <= 12; multiplier++)
            {
                sb.AppendLine($"{number} * {multiplier} = {number * multiplier}");
                
            }

            
           
            return sb.ToString();
            
        }
    }
}



