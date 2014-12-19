using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleStringDuper;

namespace StringDuplicatorDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringDuplicator Demo Application.");
            Console.Write("Enter the test string:");
            string input = Console.ReadLine();

            try
            {
                Console.WriteLine(input.Duplicate());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
