using System;
using System.Text.RegularExpressions;

namespace SansurProject
{
    public class Censor
    {
        public static string CensorTheText(string _text, string[] listOfBannedWords)
        {
            foreach (var word in listOfBannedWords)
            {
                if (_text.IndexOf(word, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    string asteriks = new string('*', word.Length);

                    _text = Regex.Replace(_text, word, asteriks, RegexOptions.IgnoreCase);
                }
            }

            return _text;
        }
    }
}
