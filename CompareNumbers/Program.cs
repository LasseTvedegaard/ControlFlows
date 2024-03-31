using System;

namespace TestFlow {
    public class Program {

        // Omdøbt metoden for at undgå forvirring med NumberStyles, som er en eksisterende klasse i .NET
        public static void CompareNumbers(int num1, int num2) {
            if (num1 == num2) {
                Console.WriteLine("Begge tal er lige store");
            } else if (num1 < num2) {
                Console.WriteLine("num2 er større end num1");
            } else if (num1 > num2) {
                Console.WriteLine("num1 er større end num2");
            }
        }

        static void Main(string[] args) {
            // Kald din metode her for at sammenligne to tal.
            CompareNumbers(5, 10);
            CompareNumbers(10, 5);
            CompareNumbers(7, 7);
        }
    }
}
