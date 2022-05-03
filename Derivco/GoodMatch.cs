using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivco
{
    public class GoodMatch
    {
        public string Match(string n1, string n2)
        {
            string matchSentence = n1 + " matches " + n2;
            string matchSentOut = n1 + " matches " + n2;
            //Console.WriteLine(matchSentence);
            string matched = "";
            int frequency;

            for (int i = 0; i < matchSentence.Length; i++)
            {

                if (!(matchSentence[i] == ' '))
                {
                    frequency = matchSentence.Count(f => (f == matchSentence[i]));
                    matched = matched + frequency.ToString();
                    matchSentence = matchSentence.Replace(matchSentence[i], ' ');
                }

            }

            //Console.WriteLine(matched);

            string sumMatchedEven = "";


            while (matched.Length != 2)
            {
                int halfway;
                string firstHalf = "";
                string secondHalf = "";

                if ((matched.Length % 2) == 0)
                {
                    halfway = matched.Length / 2;

                    for (int i = 0; i < halfway; i++)
                    {
                        firstHalf = firstHalf + matched[i];
                    }

                    for (int i = matched.Length - 1; i >= halfway; i--)
                    {
                        secondHalf = secondHalf + matched[i];
                    }

                    sumMatchedEven = "";

                    for (int i = 0; i < firstHalf.Length; i++)
                    {
                        sumMatchedEven = sumMatchedEven + ((int)Char.GetNumericValue(firstHalf[i]) + (int)Char.GetNumericValue(secondHalf[i])).ToString();
                    }

                    matched = sumMatchedEven;

                }
                else
                {
                    halfway = (matched.Length / 2);

                    for (int i = 0; i < halfway; i++)
                    {
                        firstHalf = firstHalf + matched[i];
                    }

                    for (int i = matched.Length - 1; i > halfway; i--)
                    {
                        secondHalf = secondHalf + matched[i];
                    }

                    sumMatchedEven = "";

                    for (int i = 0; i < firstHalf.Length; i++)
                    {
                        sumMatchedEven = sumMatchedEven + ((int)Char.GetNumericValue(firstHalf[i]) + (int)Char.GetNumericValue(secondHalf[i])).ToString();
                    }

                    sumMatchedEven = sumMatchedEven + matched[halfway];

                    matched = sumMatchedEven;
                }

            }

            if (Int32.Parse(matched) > 80)
            {
                return matchSentOut + " " + matched + "%, good match";
            }
            else
            {
                return matchSentOut + " " + matched + "%";
            }

        }
    }
}
