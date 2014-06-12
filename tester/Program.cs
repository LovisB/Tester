using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today);

            bool isComplex = Regex.IsMatch("Mmssssasdasdasdasdasdsadsada45'", @"^.{6,16}(?<=\d.*)(?<=[^a-zA-Z0-9].*)(?<=[A-Z].*)(?<=[A-Z].*)$");
            Console.WriteLine(isComplex);
        }
    }
}
