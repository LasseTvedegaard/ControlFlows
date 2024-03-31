using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace TestFlow {
    public class Program {

        static void Main(string[] args) {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            for (int i = numbers.Length -1; i >= 0; i--) {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}













