
using System.Collections.Generic;

namespace NamedAndOptionalParams.Classes
{
    public class WordProcessor
    {
        /// <summary>
        /// Static method to manipulate the words of a sentence
        /// </summary>
        /// <param name="sentence">Sent in string to manipulate</param>
        /// <param name="capitalizeWords">Optional param to capitalize words</param>
        /// <param name="reverseOrder">Optional param to revers the word order</param>
        /// <param name="reversWords">Optional param to revers the letters of the words</param>
        /// <returns></returns>
        public static List<string> GetWords(string sentence, bool capitalizeWords = false,
            bool reverseOrder = false, bool reversWords = false)
        {
            List<string> words = new List<string>(sentence.Split(' '));
            if (capitalizeWords)
            {
                words = CapitalizeWords(words);
            }
            return words;
        }

        /// <summary>
        /// Utility method to capitalize each word of the sentence
        /// </summary>
        private static List<string> CapitalizeWords(List<string> words)
        {
            List<string> capitalizedWords = new List<string>();
            words.ForEach(w => capitalizedWords.Add(w.Substring(0, 1).ToUpper() + w.Substring(1)));
            return capitalizedWords;
        }
    }
}
