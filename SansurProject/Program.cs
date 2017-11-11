using System;

namespace SansurProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string text = "armut, Armutlar1, elmalar, narlar, nar olmak uzere";
            string[] bannedWords = { "Armut", "nar", "berk" };

            Console.WriteLine("Sansurlenecek Yazi: " + text.ToString());

            string censoredText = Censor.CensorTheText(text, bannedWords);

            Console.WriteLine(censoredText);
            Console.ReadLine(); 
        }
    }
}
