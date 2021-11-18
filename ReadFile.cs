using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    class ReadFile
    {
        List<Dialog> dialogs = new List<Dialog>();

        public List<Dialog> ReadDialog()
        {
            string[] lines = File.ReadAllLines("dialog.txt");
            List<Dialog> dialogs = new List<Dialog>();

            foreach (var line in lines)
            {
                string[] words = line.Split(',');
                string purpose = words[0];
                int age = Int32.Parse(words[1]);
                int duration = Int32.Parse(words[2]);
                string enterDay = words[3];

                Dialog dialog = new Dialog(purpose, age, duration, enterDay);
                dialogs.Add(dialog);
            }
            return dialogs;
        }

        public List<Passport> ReadPassport()
        {

            string[] lines = File.ReadAllLines("passport.txt");
            List<Passport> passports = new List<Passport>();

            foreach (var line in lines)
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

                Passport passport = new Passport(name, age, dateOfBirth, sex, country, purpose, duration, enterDay, passPortNumber, exp);
                passports.Add(passport);
            }
            return passports;
        }


        public string[] ReadRule()
        {
            string[] lines = File.ReadAllLines("rule.txt");

            return lines;
        }
    }



}
