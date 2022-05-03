using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivco
{
    public class ReadCSV
    {
        public static void CsvRead()
        {
            string[] linesCsv = System.IO.File.ReadAllLines(@"C:\Users\Nikkhil Singh\source\repos\Derivco\Derivco\matching.csv");

            //clean the lines in textfile.
            //intructions did not say if the format will be changed in textfile so just worked on default intructions
            //given as per the word document.
            for (int i = 0; i < linesCsv.Length; i++)
            {
                linesCsv[i] = linesCsv[i].Remove(0, 3);//removes the number, fullstop and space
            }

            string[] noDuplicates = linesCsv.Distinct().ToArray();

            ArrayList males = new ArrayList();
            ArrayList females = new ArrayList();

            for (int i = 0; i < noDuplicates.Length; i++)
            {
                char gender = noDuplicates[i][noDuplicates[i].Length - 1];
                if (gender == 'm')
                {
                    males.Add(noDuplicates[i].Substring(0, noDuplicates[i].IndexOf(',')));
                }
                else if (gender == 'f')
                {
                    females.Add(noDuplicates[i].Substring(0, noDuplicates[i].IndexOf(',')));
                }
            }

            ArrayList matchedMalesFemales = new ArrayList();

            GoodMatch matching = new GoodMatch();

            for (int i = 0; i < males.Count; i++)
            {
                for (int j = 0; j < females.Count; j++)
                {
                    matchedMalesFemales.Add(matching.Match(males[i].ToString(),females[j].ToString()));
                }
            }

            try
            {
                using (TextWriter writer = File.CreateText(@"C:\Users\Nikkhil Singh\source\repos\Derivco\Derivco\output.txt"))
                {
                    foreach (string s in matchedMalesFemales)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Please check your file path!!!!!!!!!!");
            }

            

        }
    }
}
