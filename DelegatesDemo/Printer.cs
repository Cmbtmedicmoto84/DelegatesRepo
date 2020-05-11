using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Printer
    {
        public delegate int StringToIntFunction(string s);
        public void TestDelegate()
        {
            StringToIntFunction stringToIntDelegate;

            stringToIntDelegate = GetLength;
            int resultLengthOfWord = stringToIntDelegate("packers");
            Console.WriteLine(resultLengthOfWord);

            stringToIntDelegate = GetHighestIndex;
            int resultHighestIndexOfWord = stringToIntDelegate("packers");
            Console.WriteLine(resultHighestIndexOfWord);
        }
        public int GetLength(string word)
        {
            return word.Length;
        }
        public int GetHighestIndex(string word)
        {
            return word.Length - 1;
        }
        public void PrintName(string name) //name = "miek"
        {
            Console.WriteLine(name);
        }

        public string GetName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            return name;
        }

        public void Execute()
        {

            PrintName(GetName());
        }
    }
}
