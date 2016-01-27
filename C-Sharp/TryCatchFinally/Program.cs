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
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\C#Programs\TryCatchFinally\TryCatchFinally\SampleText.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("{0} does not exist.", ex.FileName);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
