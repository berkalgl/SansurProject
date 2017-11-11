using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SansurProject
{
    public class Censor
    {
        public static string CensorTheText(string _text, string[] listOfBannedWords)
        {
            
            foreach (var word in listOfBannedWords)
            {

                int wordStartAt = _text.IndexOf(word, StringComparison.OrdinalIgnoreCase);

                if (wordStartAt != -1)
                {
                    
                    int priorIndex = 0;
                    int lentghOfWord = word.Length;
                    string asteriks = new string('*', lentghOfWord);

                    StringBuilder result = new StringBuilder();


                    while(wordStartAt != -1)
                    {
                        result.Append(_text.Substring(priorIndex, wordStartAt - priorIndex));
                        result.Append(asteriks);

                        wordStartAt += lentghOfWord;
                        priorIndex = wordStartAt;

                        wordStartAt = _text.IndexOf(word, wordStartAt, StringComparison.OrdinalIgnoreCase);
                    }

                    result.Append(_text.Substring(priorIndex));

                    _text = result.ToString();

                }
            }

            return _text.ToString();
        }
    }
}
