using System;

namespace Opdracht_0
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
            int getal = ReadInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt.", getal);
            int leeftijd = ReadInt("hoe oud ben je? ", 0, 120);
            Console.WriteLine("Je bent {0} jaar oud.", leeftijd);
            string naam = ReadString("Hoe heet je? ");
            Console.WriteLine("Aangenaam kennis met je te maken, {0}.", naam);
            Console.ReadKey();
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
