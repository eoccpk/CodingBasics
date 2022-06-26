using System;
using System.IO;

namespace _20220701_FileIO
{
    // Source : https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
    public class ExampleTextFiles
    {
        public void Write()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\GitHub\\data.txt");
                
                //Write a line of text
                sw.WriteLine("Hello World!!");
                
                //Write a second line of text
                sw.WriteLine("Writing to File");

                //Close the file
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void Read()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("D:\\GitHub\\data.txt");
                
                //Read the first line of text
                line = sr.ReadLine();
                
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

    }
}
