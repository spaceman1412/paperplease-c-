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
            // Manage();
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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What's do you want to do?");
                Console.WriteLine("1. Play game");
                Console.WriteLine("2. Manage");
                Console.Write("Input the number (1-2): ");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    Game();
                }
                if (a == "2")
                {
                    Manage();
                }
            }
        }


        public static void Manage()
        {
            Console.Clear();
            Console.WriteLine("Input how many passengers you want to manage (type number only): ");
            int number = Int32.Parse(Console.ReadLine());
            Manage manage = new Manage();
            manage.Input(number);
            manage.Output();
        }

        public static void Game()
        {
            int count = 1;
            int point = 0;
            foreach (var person in persons)
            {
                Person.Passport passport = person.getPassport();
                Person.Dialog dialog = person.getDialog();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("********** " + count + ". " + passport.getName() + " **********");
                    Console.WriteLine("Your current point: " + point);
                    Console.WriteLine("1.Read the rule");
                    Console.WriteLine("2.View the passport");
                    Console.WriteLine("3.View the dialogue");
                    Console.Write("Enter number(1-3) if u want to guess enter (wrong or true): ");
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
                        string back = passport.Output("Game");
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
                    if (input == "true")
                    {
                        List<string> errors = person.Compare();
                        if (errors.Count() == 0)
                        {
                            Console.WriteLine("You guess right");
                            Console.WriteLine("Your point: " + point + " + 10");
                            point += 10;

                        }
                        else
                        {
                            Console.WriteLine("You guess wrong");
                            Console.Write("The errors are : ");
                            foreach (var error in errors)
                            {
                                Console.Write(" " + error);
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        count++;
                        break;
                    }
                    if (input == "wrong")
                    {
                        List<string> errors = person.Compare();
                        if (errors.Count() > 0)
                        {
                            Console.WriteLine("You guess right");
                            Console.Write("The errors are : ");
                            foreach (var error in errors)
                            {
                                Console.Write(" " + error);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Your point: " + point + " + 10");
                            point += 10;
                        }
                        else
                        {
                            Console.WriteLine("You guess wrong there are no errors");
                        }
                        Console.ReadLine();
                        count++;
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Congratulations you finish the game!!");
                Console.WriteLine("Your total point is " + point);
            }
        }
    }
}
