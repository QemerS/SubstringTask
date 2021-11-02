using System;

namespace SubstringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin");
            string text = Console.ReadLine();
            if (text.Length > 50)
            {
                
             Console.WriteLine(text.Substring(0, 50) + "...");
            }
            else { 
            Console.WriteLine(text);
            }
        }
    }
}
