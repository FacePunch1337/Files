using System;
using System.IO;

namespace Files
{
    internal class Program
    {
        const String _FName = "file.txt";  
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(_FName);

            sw.WriteLine("Hello File 2!");
            sw.Close();
                
            try 
            {
                using (StreamReader sr = new StreamReader(_FName))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
