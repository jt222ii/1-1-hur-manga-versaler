using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HurMangaVersaler.Model
{
    public class TextAnalyzer
    {
        public int GetNumberOfCapitals(string input)
        {
            int numberOfCapital = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    numberOfCapital++;
                }
            }
            return numberOfCapital;
        }
    }
}