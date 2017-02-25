using System;
using static System.Console;
using static System.Convert;
using static System.Exception;
namespace Chapter07Exercises
{
    class Program
    {
        /// <summary>
        ///     String array representing exception types
        /// </summary>
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };

        /// <summary>
        ///     Main method for executing console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            foreach(var type in eTypes)
            {
                try
                {
                    WriteLine("Main() try block reached.");
                    WriteLine($"Throwing Exception of the type: {type}");
                    ThrowException(type);
                    WriteLine("Main() try block continues...");
                }
                catch(IndexOutOfRangeException e) when (type == "filter")
                {
                    WriteLine($"Main() FILTERED IndexOutOfRangeException catch block reached.\nMessage: {e.Message}");
                }
                catch(IndexOutOfRangeException e)
                {
                    WriteLine($"Main() Non-filtered IndexedOutOfRangeException catch block reached.\nMessage: {e.Message}");
                }
                catch
                {
                    WriteLine($"Main() general catch block reached");
                }
                finally
                {
                    WriteLine("Main() finally block reached.");
                }
            }
            ReadKey();
        }

        /// <summary>
        ///     Method for generating the exception to be thrown
        /// </summary>
        /// <param name="exceptionType">The type of excpetion being thrown</param>
        static void ThrowException(string exceptionType)
        {
            WriteLine($"ThrowException(\"{exceptionType}\") reached");
            switch (exceptionType)
            {
                case "none":
                    WriteLine("Not throwing an exception");
                    break;
                case "simple":
                    WriteLine("Throwing  System.Exception");
                    break;
                case "index":
                    WriteLine("Throwing System.IndexOutOfRangeException");
                    eTypes[5] = "error"; //Instead of "throw new IndexOutOfRangeException()", we just access an out of bounds index to cause the excpetion
                    break;
                case "nested index":
                    try
                    {
                        WriteLine("ThrowException(\"nested index\") try block reached.");
                        WriteLine("ThrowExcpetion(\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        WriteLine("ThrowException(\"nested index\") general catch block reached.");
                    }
                    finally
                    {
                        WriteLine("ThrowException(\"nested index\") finally block reached.");
                    }
                    break;
                case "filter":
                    try
                    {
                        WriteLine("ThrowException(\"filter\") try block reached.");
                        WriteLine("ThrowException(\"index\") called");
                        ThrowException("index");                 
                    }
                    catch
                    {
                        WriteLine("ThrowException(\"filter\") general catch block reached");
                        eTypes[5] = "Throw new IndexOutOfRangeException";
                    }
                    break;
            }
        }

    }
}
