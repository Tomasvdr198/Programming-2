using System;
using System.IO;

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
            string fileName = "E:\\Users\\tomas\\Documents\\GitHub\\Programming-2\\Week 4\\Opdracht 1\\names.txt";
            Person person = ReadPerson(fileName);
            if(person.name == null)
            {
                Console.WriteLine("Welcome new guy");
                person = ReadPerson();
                WritePerson(person, fileName);
            }
            else
            {
                Console.WriteLine("Welcome back " + person.name);
                Console.WriteLine("We have the next data stored");
                ShowPerson(person);

            }
                                 
            Console.ReadKey();
        }

        Person ReadPerson()
        {
            Person person = new Person();
            Console.Write("What's your name?");
            string name = Console.ReadLine();
            Console.Write("Where do you live?");
            string adress = Console.ReadLine();
            Console.Write("How old are you?");
            int age = int.Parse(Console.ReadLine());

            person.age = age;
            person.adress = adress;
            person.name = name;

            return person;
        }

        void WritePerson(Person p, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {

                writer.WriteLine(p.name);
                writer.WriteLine(p.adress);
                writer.WriteLine(p.age);
                Console.WriteLine("stored in " + fileName);
            }
        }

        void ShowPerson(Person p)
        {
            Console.WriteLine("{0, -10} :{1, 10} ", "Name ",  p.name);
            Console.WriteLine("{0, -10} :{1, 10} ", "Age ", p.age);
            Console.WriteLine("{0, -10} :{1, 10} ", "Adress ", p.adress);

        }

        Person ReadPerson(string fileName)
        {
            Person person = new Person();

            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            int counter = 0;
            string line;

            System.IO.StreamReader file =
            new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                if(line == name)
                {
                    person.name = line;
                    counter++;
                    line = file.ReadLine();
                    person.adress = line;
                    counter++;
                    line = file.ReadLine();
                    person.age = int.Parse(line);
                    break;
                }
                counter++;
            }
            

            return person;
        }


    }

    class Person
    {
        public string name;
        public string adress;
        public int age;
    }
}
