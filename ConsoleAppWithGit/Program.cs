using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\hello_world.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string txt = sr.ReadLine();
                while (txt != null)
                {
                    Console.WriteLine(txt);
                    txt = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
