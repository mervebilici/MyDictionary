using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Ali", 001);
            myDictionary.Add("Ayşe", 002);
            myDictionary.Add("Mert", 003);
            myDictionary.Add("Selin", 004);
            myDictionary.Add("Ecem", 005);

            Console.WriteLine(myDictionary.count);
        }
    }
}
