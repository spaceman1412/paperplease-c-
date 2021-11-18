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
        string name;
        int age;
        string dateOfBirth;
        string sex;
        string country;
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

        public string getExp()
        {
            return this.exp;
        }

        public void setExp(string exp)
        {
            this.exp = exp;
        }
        //ngay het han

        public Passport(string name, int age, string dateOfBirth, string sex, string country, string purpose, int duration, string enterDay, string passPortNumber, string exp)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.country = country;
            this.passPortNumber = passPortNumber;
            this.exp = exp;
            this.purpose = purpose;
            this.duration = duration;
            this.enterDay = enterDay;
            this.age = age;
        }


        public string Output()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Date of Birth: " + this.dateOfBirth);
            Console.WriteLine("Sex: " + this.sex);
            Console.WriteLine("Country: " + this.country);
            Console.WriteLine("Exp: " + this.exp);
            Console.WriteLine("*****" + this.passPortNumber + "******");
            // clear and return
            Console.Write("Turn back (b): ");
            string a = Console.ReadLine();
            return a;

        }
    }


}
