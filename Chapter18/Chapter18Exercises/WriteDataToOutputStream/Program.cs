using static System.Console;
using System.IO;

namespace WriteDataToOutputStream
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream file = new FileStream("Log.txt", FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(file))
                {

                    //Write data to the file
                    sw.WriteLine("This is the millennium of Aftermath");
                    sw.WriteLine("There aint gonna be anything after that");
                    sw.WriteLine("So give me one more platnium plaque");
                    sw.WriteLine("And F rap, you can have it back");
                }
            }
            catch (IOException e)
            {
                WriteLine("IOException thown");
                WriteLine(e.ToString());
                ReadLine();
                return;
            }
        }
    }
}
