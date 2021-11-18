using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;//Sử dụng thư viện này để làm việc với Stream

namespace Project
{
    class Program
    {
        public static List<Person> persons = new List<Person>();

        public static Rule rule = new Rule(null);
        static void Main(string[] args)
        {
            ReadData();
            Start();

        }

        public static void ReadData()
        {
            ReadFile read = new ReadFile();

            Rule rule1 = new Rule(read.ReadRule());
            rule = rule1;


            persons = read.ReadPerson();
        }
        public static void Start()
        {
            int count = 1;
            foreach (var person in persons)
            {
                Person.Passport passport = person.getPassport();
                Person.Dialog dialog = person.getDialog();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("********** " + count + ". " + passport.getName() + " **********");
                    Console.WriteLine("1.Read the rule");
                    Console.WriteLine("2.View the passport");
                    Console.WriteLine("3.View the dialogue");
                    Console.Write("Enter number(1-3) if you want to next enter n: ");
                    string input = Console.ReadLine();
                    Console.Clear();

                    if (input == "1")
                    {
                        string back = rule.Output();
                        if (back == "b")
                        {
                            Console.Clear();
                        }
                    }
                    if (input == "2")
                    {
                        string back = passport.Output();
                        if (back == "b")
                        {
                            Console.Clear();
                        }
                    }
                    if (input == "3")
                    {
                        string back = dialog.Output();
                        if (back == "b")
                        {
                            Console.Clear();
                        }
                    }
                    if (input == "n")
                    {
                        break;
                    }
                }
                count++;
            }
        }
    }
}
