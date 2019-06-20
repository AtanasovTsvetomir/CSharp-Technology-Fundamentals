using System;
using System.Collections.Generic;

namespace declaration
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;
            fruits["apple"] = 1.20;
            fruits["kiwi"] = 3.20;


            var list = new Dictionary<string, char>();
            list.Add("Niki", 'N');
            list.Add("Pesho", 'P');
            list.Add("Gosho", 'G');
            list.Add("Ivo", 'I');

            list["Ivo"] = 'I';
            Console.WriteLine(list["Ivo"]);

            

        }
    }
}
