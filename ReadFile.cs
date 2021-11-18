using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class ReadFile
    {

        public Person.Dialog ReadDialog(string line)
        {

            string[] words = line.Split(',');
            string purpose = words[0];
            int age = Int32.Parse(words[1]);
            int duration = Int32.Parse(words[2]);
            string enterDay = words[3];

            Person.Dialog dialog = new Person.Dialog(purpose, age, duration, enterDay);

            return dialog;
        }

        public Person.Passport ReadPassport(string line)
        {
            string[] words = line.Split(',');
            string name = words[0];
            int age = Int32.Parse(words[1]);
            string dateOfBirth = words[2];
            string sex = words[3];
            string country = words[4];
            string purpose = words[5];
            int duration = Int32.Parse(words[6]);
            string enterDay = words[7];
            string passPortNumber = words[8];
            string exp = words[9];

            Person.Passport passport = new Person.Passport(name, age, dateOfBirth, sex, country, purpose, duration, enterDay, passPortNumber, exp);

            return passport;
        }

        public List<Person> ReadPerson()
        {
            List<Person> persons = new List<Person>();
            string[] dialog = File.ReadAllLines("dialog.txt");
            string[] passport = File.ReadAllLines("passport.txt");

            for (int i = 0; i < dialog.Length; i++)
            {
                Person.Dialog Dialog = ReadDialog(dialog[i]);
                Person.Passport Passport = ReadPassport(passport[i]);

                Person person = new Person(Dialog, Passport);
                persons.Add(person);
            }

            return persons;

        }


        public string[] ReadRule()
        {
            string[] lines = File.ReadAllLines("rule.txt");

            return lines;
        }
    }



}
