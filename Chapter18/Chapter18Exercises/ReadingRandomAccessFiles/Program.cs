using System.Text;
using System.IO;
using static System.Console;

namespace ReadingRandomAccessFiles
{
    /// <summary>
    /// Program will write its code to the console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;

            try
            {
                FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);
                byteData = new byte[aFile.Length];
                charData = new char[aFile.Length];
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Read(byteData, 0, (int)aFile.Length);
            }
            catch (IOException e)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(e.ToString());
                ReadKey();
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);
            WriteLine(charData);
            ReadKey();
        }
    }
}
