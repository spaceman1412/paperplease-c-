using System;
using System.Collections.Generic;

namespace Project
{

    public class Rule
    {
        string[] rule;

        public Rule(string[] rule)
        {
            this.rule = rule;
        }

        public string[] getRule()
        {
            return this.rule;
        }

        public string Output()
        {
            foreach (var line in rule)
            {
                Console.WriteLine(line);
            }
            Console.Write("Turn back (b): ");
            string a = Console.ReadLine();
            return a;
        }
    }

    public class Person
    {
        Dialog dialog;
        Passport passport;

        public Dialog getDialog()
        {
            return this.dialog;
        }

        public void setDialog(Dialog dialog)
        {
            this.dialog = dialog;
        }

        public Passport getPassport()
        {
            return this.passport;
        }

        public void setPassport(Passport passport)
        {
            this.passport = passport;
        }


        public Person(Dialog dialog, Passport passport)
        {
            this.dialog = dialog;
            this.passport = passport;
        }

        public List<string> Compare()
        {
            List<string> errors = new List<string>();
            if (dialog.getAge() != passport.getAge())
            {
                errors.Add("age");
            }
            if (passport.getPassPortNumber().Substring(0, 2) != "19")
            {
                errors.Add("ID");
            }
            if (dialog.getName() != passport.getName())
            {
                errors.Add("Name");
            }
            if (dialog.getPurpose() != passport.getPurpose())
            {
                errors.Add("Purpose");
            }
            if (dialog.getDuration() != passport.getDuration())
            {
                errors.Add("Duration");
            }
            return errors;
        }
        public class Dialog
        {
            string name;

            string purpose;
            int age;

            int duration;

            public string getName()
            {
                return this.name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getPurpose()
            {
                return this.purpose;
            }

            public void setPurpose(string purpose)
            {
                this.purpose = purpose;
            }
            public int getAge()
            {
                return this.age;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public int getDuration()
            {
                return this.duration;
            }

            public void setDuration(int duration)
            {
                this.duration = duration;
            }



            //ngay nhap canh

            public Dialog(string name, string purpose, int age, int duration)
            {
                this.name = name;
                this.purpose = purpose;
                this.age = age;
                this.duration = duration;

            }

            public string Output()
            {
                Console.WriteLine("Me: What's your name?");
                Console.WriteLine("You: My name is " + this.name);
                Console.WriteLine("Me: What's your purpose of this trip?");
                Console.WriteLine("You: I go to " + this.purpose);
                Console.WriteLine("Me: How old are you? ");
                Console.WriteLine("You: I'm " + this.age);
                Console.WriteLine("Me: When you go back?");
                Console.WriteLine("You: I go back in the next " + this.duration + " days");
                // clear and return
                Console.Write("Turn back (b): ");
                string a = Console.ReadLine();
                return a;
            }

        }

        public class Passport
        {
            string name;
            int age;
            string dateOfBirth;
            string sex;
            string country;
            string purpose;
            int duration;



            string passPortNumber;



            public string getPurpose()
            {
                return this.purpose;
            }

            public void setPurpose(string purpose)
            {
                this.purpose = purpose;
            }

            public int getAge()
            {
                return this.age;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public int getDuration()
            {
                return this.duration;
            }

            public void setDuration(int duration)
            {
                this.duration = duration;
            }




            public string getName()
            {
                return this.name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getDateOfBirth()
            {
                return this.dateOfBirth;
            }

            public void setDateOfBirth(string dateOfBirth)
            {
                this.dateOfBirth = dateOfBirth;
            }

            public string getSex()
            {
                return this.sex;
            }

            public void setSex(string sex)
            {
                this.sex = sex;
            }

            public string getCountry()
            {
                return this.country;
            }

            public void setCountry(string country)
            {
                this.country = country;
            }

            public string getPassPortNumber()
            {
                return this.passPortNumber;
            }

            public void setPassPortNumber(string passPortNumber)
            {
                this.passPortNumber = passPortNumber;
            }




            public Passport(string name, int age, string dateOfBirth, string sex, string country, string purpose, int duration, string passPortNumber)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                this.sex = sex;
                this.country = country;
                this.passPortNumber = passPortNumber;
                this.purpose = purpose;
                this.duration = duration;
                this.age = age;
            }


            public string Output(string screen)
            {
                Console.WriteLine("Name: " + this.name);
                Console.WriteLine("Date of Birth: " + this.dateOfBirth);
                Console.WriteLine("Sex: " + this.sex);
                Console.WriteLine("Country: " + this.country);
                Console.WriteLine("Purpose: " + this.purpose);
                Console.WriteLine("Duration: " + this.duration);
                Console.WriteLine("*****" + this.passPortNumber + "******");
                // clear and return
                if (screen == "Game")
                {
                    Console.Write("Turn back (b): ");
                    string a = Console.ReadLine();
                    return a;
                }
                else if (screen == "Manage")
                {
                    Console.Write("Go next (n): ");
                    string a = Console.ReadLine();
                    return a;
                }
                else
                {
                    return null;
                }
            }
        }
    }


}
