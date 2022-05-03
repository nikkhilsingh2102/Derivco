using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Derivco
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            string regexName = "^[a-zA-Z]+$";

            Console.WriteLine("Enter name 1:");
            string name1 = Console.ReadLine();

            while (((Regex.IsMatch(name1, regexName))==false) || (string.IsNullOrEmpty(name1)))
            {
                Console.WriteLine("Enter a single name with only letters, make sure it is not empty, has no special characters and no spaces!");
                name1 = Console.ReadLine();
            }

            name1.ToLower();

            Console.WriteLine("Enter name 2:");
            string name2 = Console.ReadLine();

            while (((Regex.IsMatch(name2, regexName)) == false) || (string.IsNullOrEmpty(name1)))
            {
                Console.WriteLine("Enter a single name with only letters, make sure it is not empty, has no special characters and no spaces!");
                name2 = Console.ReadLine();
            }

            name2.ToLower();

            GoodMatch matchup = new GoodMatch();
            Console.WriteLine(matchup.Match(name1,name2));

            ReadCSV.CsvRead();

        }

        
    }
}
