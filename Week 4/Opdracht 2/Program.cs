using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Opdracht_2
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
            string fileName = "E:\\Users\\tomas\\Documents\\GitHub\\Programming-2\\Week 4\\Opdracht 2\\words.txt";
            HangMan hangMan = new HangMan();
            List<String> wordsList = hangMan.WordsList();
            string word = SelectWord(wordsList);
            hangMan.Init(word);
            PlayHangMan(hangMan);

            Console.WriteLine("Het geheime woord is: " + hangMan.secretWord);
            Console.WriteLine("Het geraden woord is: " + hangMan.quessedWord);
            Console.ReadKey();

            
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random();

            int r = rnd.Next(words.Count);
            string word = words[r];

            return word;
        }

        bool PlayHangMan(HangMan hangMan)
        {
            List<char> inputChars;


            if(hangMan.secretWord == hangMan.quessedWord)
            {
                return true;
            }
            else
            {
                return false;
            }

            return true;
        }



    }

    class HangMan
    {
        public string secretWord;
        public string quessedWord;

        

        public void Init(string getSecretWord)
        {
            secretWord = getSecretWord;
            int length = secretWord.Length;
            int i = 0;
            while (i < length)
            {
                quessedWord += ". ";
                i++;
            }

                

        }

        public List<string> WordsList()
        {
            List<string> wordsList = new List<string>();
            String filename = "E:\\Users\\tomas\\Documents\\GitHub\\Programming-2\\Week 4\\Opdracht 2\\words.txt";
            StreamReader reader = File.OpenText(filename);
            var lines = File.ReadAllLines(filename);
            var r = new Random();

            int i = 0;
            string line;

            while (i < 20)
            {
                var randomLineNumber = r.Next(0, lines.Length - 1);
                line = lines[randomLineNumber];
                if (line.Length >= 3)
                {
                    wordsList.Add(line);
                    i++;
                }
            }

            return wordsList;

        }

       

    }
}
