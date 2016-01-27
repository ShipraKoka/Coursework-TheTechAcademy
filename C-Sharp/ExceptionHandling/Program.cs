using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            string logPath = @"C:\C#Programs\ExceptionHandling\ExceptionHandling\ExceptionLog.txt";

            StreamReader streamReader = null;

            try
            {
                string textFilePath = @"C:\C#Programs\ExceptionHandling\ExceptionHandling\TextFile.txt";
                streamReader = new StreamReader(textFilePath);
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("{0} does not exist.", ex.FileName);
                using (StreamWriter streamWriter = File.AppendText(logPath))
                {
                    streamWriter.WriteLine(ex.Message);
                    streamWriter.WriteLine(ex.StackTrace);
                    streamWriter.WriteLine();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter streamWriter = File.AppendText(logPath))
                {
                    streamWriter.WriteLine(ex.Message);
                    streamWriter.WriteLine(ex.StackTrace + "\n");
                    streamWriter.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter streamWriter = File.AppendText(logPath))
                {
                    streamWriter.WriteLine(ex.Message);
                    streamWriter.WriteLine(ex.StackTrace + "\n");
                    streamWriter.WriteLine();
                }
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}

