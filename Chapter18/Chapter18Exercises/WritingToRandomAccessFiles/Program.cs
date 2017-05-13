using static System.Console;
using System.IO;
using System.Text;

namespace WritingToRandomAccessFiles
{
    class Program
    {
        /// <summary>
        /// Will write the text to a file in WritingToRandomAccessFiles\bin\Debug
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            byte[] byteData;
            char[] charData;

            try
            {
                FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
                charData = "Haters run around all day saying Dre fell off.".ToCharArray();
                byteData = new byte[charData.Length];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length, byteData, 0, true);

                //Move file pointer to beginning of file
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byteData, 0, byteData.Length);
            }
            catch (IOException ex)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(ex.ToString());
                ReadKey();
                return;
            }
        }
    }
}
