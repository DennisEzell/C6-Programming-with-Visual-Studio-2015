using NamedAndOptionalParams.Classes;
using System.Collections.Generic;
using static System.Console;

namespace NamedAndOptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "haters run around all day saying dre fell off";
            List<string> words;
            words = WordProcessor.GetWords(sentence, capitalizeWords: true);
            WriteLine("Capitalizing the sentence");

            words.ForEach(w => Write(w + " "));
            ReadKey();
        }
    }
}
