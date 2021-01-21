using System;

namespace Example_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Sydney, Melbourne");
            myDictionary.Add(3, "Kanberra");
            myDictionary.PrintValues();
            Console.ReadKey();
        }
    }
}
