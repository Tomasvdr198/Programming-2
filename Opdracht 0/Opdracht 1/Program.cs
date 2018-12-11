using System;
using static Opdracht_1.Enums;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Month month = (Month)1;

            PrintMonth(month);

            PrintMonths();
            Console.ReadKey();
        }
     
       
        static void PrintMonth(Month month)
        {
            
            Console.WriteLine(month);
        }

        static void PrintMonths()
        {
           foreach(int i in Enum.GetValues(typeof(Month)))
            {
                Month month = (Month)i;
                Console.WriteLine(String.Format("{0,5} . {1, -10}", i.ToString(), month));
            }
        }

        Month AskMonth(String question)
        {
           int number = ReadInt("Enter a month number", 1, 12);

            Month month = (Month)number;
            
            return month;
        }

      
        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int ReadInt(string question, int min, int max)
        {
            int number = ReadInt(question);
            while (number < min || number > max)
            {

                number = number = ReadInt(question);
            }
            return number;
        }

        string ReadString(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            return answer;
        }
    }
}
