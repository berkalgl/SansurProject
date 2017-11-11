using System;

namespace SansurProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string text = "Armut1, armut, elmalar, narlar, nar olmak uzere";
            string[] bannedWords = { "armut", "nar", "berk" };

            Console.WriteLine("Sansurlenecek Yazi: " + text.ToString());

            string censoredText = Censor.CensorTheText(text, bannedWords).ToString();

            Console.WriteLine(censoredText);
            Console.ReadLine(); 
        }
    }
}
