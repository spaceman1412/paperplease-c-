using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class Manage
    {
        List<Person> persons = new List<Person>();

        public void Input(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("********** " + i + "/" + number + " *************");
                Person.Dialog dialog = new Person.Dialog(null, null, 0, 0);
                Person.Passport passport = InputPassport();

                Person person = new Person(dialog, passport);
                this.persons.Add(person);
            }

            Person.Passport InputPassport()
            {
                Console.Write("The name of person: ");
                string name = Console.ReadLine();
                Console.Write("The date of birth(day/month/year): ");
                string dateOfBirth = Console.ReadLine();
                Console.Write("The sex of person(Male/Female): ");
                string sex = Console.ReadLine();
                Console.Write("The country of person: ");
                string country = Console.ReadLine();
                Console.Write("The purpose of person: ");
                string purpose = Console.ReadLine();
                Console.Write("How many days the person go (input number only) : ");
                int duration = Int32.Parse(Console.ReadLine());
                Console.Write("The passport number you want this person have: ");
                string passPortNumber = Console.ReadLine();

                Person.Passport passport = new Person.Passport(name, 0, dateOfBirth, sex, country, purpose, duration, passPortNumber);
                return passport;
            }
        }
        public void Output()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. View the list of passengers");
                Console.WriteLine("2. Remove someone in the list");
                Console.WriteLine("3. Insert more passengers");

                Console.Write("Type the number you want (1-3) if you want to exit type exit: ");
                string num = Console.ReadLine();
                int count = 1;

                if (num == "1")
                {
                    Console.Clear();
                    foreach (var person in persons)
                    {
                        Console.Clear();
                        string a = "a";
                        while (a != "n")
                        {
                            Console.WriteLine("*******" + count + "/" + persons.Count + "*******");
                            a = person.getPassport().Output("Manage");
                        }
                        count++;
                    }
                }
                if (num == "2")
                {
                    Console.Clear();
                    Console.Write("Input the index (so thu tu) of passengers you want to remove (input number only) : ");
                    int index = Int32.Parse(Console.ReadLine()) - 1;
                    persons.RemoveAt(index);
                }
                if (num == "3")
                {
                    Console.Clear();
                    Console.Write("Input the number of passengers you want to insert (input number only) : ");
                    int number = Int32.Parse(Console.ReadLine());
                    Input(number);
                }
                if (num == "exit")
                {
                    break;
                }
            }

        }

    }
}