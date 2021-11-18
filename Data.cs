using System;

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
        static string name;
        static int age;
        static string dateOfBirth;
        static string sex;
        static string country;

        public string getName()
        {
            return name;
        }

        public void setName(string Name)
        {
            name = Name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int Age)
        {
            age = Age;
        }

        public string getDateOfBirth()
        {
            return dateOfBirth;
        }

        public void setDateOfBirth(string DateOfBirth)
        {
            dateOfBirth = DateOfBirth;
        }

        public string getSex()
        {
            return sex;
        }

        public void setSex(string Sex)
        {
            sex = Sex;
        }

        public string getCountry()
        {
            return country;
        }

        public void setCountry(string Country)
        {
            country = Country;
        }



        static Dialog dialog;

        static Passport passport;

        public Dialog getDialog()
        {
            return dialog;
        }

        public void setDialog(Dialog dialog1)
        {
            dialog = dialog1;
        }

        public Passport getPassport()
        {
            return passport;
        }

        public void setPassport(Passport passport1)
        {
            passport = passport1;
        }


        public Person(string Name, int Age, string DateOfBirth, string Sex, string Country, Dialog Dialog, Passport Passport)
        {
            name = Name;
            age = Age;
            dateOfBirth = DateOfBirth;
            sex = Sex;
            country = Country;
            dialog = Dialog;
            passport = Passport;
        }

        public class Dialog
        {
            string purpose;
            int age;

            int duration;

            string enterDay;

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


            public string getEnterDay()
            {
                return this.enterDay;
            }

            public void setEnterDay(string enterDay)
            {
                this.enterDay = enterDay;
            }

            //ngay nhap canh

            public Dialog(string purpose, int age, int duration, string enterDay)
            {
                this.purpose = purpose;
                this.age = age;
                this.duration = duration;
                this.enterDay = enterDay;
            }

            public string Output()
            {
                Console.WriteLine("Me: What's your purpose of this trip?");
                Console.WriteLine("You: I go to " + this.purpose);
                Console.WriteLine("Me: How old are you? ");
                Console.WriteLine("You: I'm " + this.age);
                Console.WriteLine("Me: When you go back?");
                Console.WriteLine("You: I go back at " + this.enterDay);
                // clear and return
                Console.Write("Turn back (b): ");
                string a = Console.ReadLine();

                return a;
            }

        }

        public class Passport
        {

            string purpose;
            int duration;

            string enterDay;

            string passPortNumber;

            string exp;

            public string getPurpose()
            {
                return this.purpose;
            }

            public void setPurpose(string purpose)
            {
                this.purpose = purpose;
            }

            public int getDuration()
            {
                return this.duration;
            }

            public void setDuration(int duration)
            {
                this.duration = duration;
            }

            public string getEnterDay()
            {
                return this.enterDay;
            }

            public void setEnterDay(string enterDay)
            {
                this.enterDay = enterDay;
            }


            public string getPassPortNumber()
            {
                return this.passPortNumber;
            }

            public void setPassPortNumber(string passPortNumber)
            {
                this.passPortNumber = passPortNumber;
            }

            public string getExp()
            {
                return this.exp;
            }

            public void setExp(string exp)
            {
                this.exp = exp;
            }
            //ngay het han

            public Passport(string purpose, int duration, string enterDay, string passPortNumber, string exp)
            {
                this.passPortNumber = passPortNumber;
                this.exp = exp;
                this.purpose = purpose;
                this.duration = duration;
                this.enterDay = enterDay;
            }


            public string Output()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Date of Birth: " + dateOfBirth);
                Console.WriteLine("Sex: " + sex);
                Console.WriteLine("Country: " + country);
                Console.WriteLine("Exp: " + this.exp);
                Console.WriteLine("*****" + this.passPortNumber + "******");
                // clear and return
                Console.Write("Turn back (b): ");
                string a = Console.ReadLine();
                return a;

            }
        }
    }


}
