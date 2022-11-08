using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            char posledne = sentence[sentence.Length - 1];
            char[] interpunkcie = { '?', '!' };
            string result = sentence.Trim(interpunkcie);
            if (sentence[sentence.Length - 1] == '?' || sentence[sentence.Length - 1] == '!')
            {
                return result + posledne;
            }
            else
            {
                return result;
            }

        }
    }
}
