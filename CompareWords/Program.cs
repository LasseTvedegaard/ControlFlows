using System;

namespace TestFlow {
    public class Program {

        public static void CompareWords(string word1, string word2) {
            if (word1 == word2) {
                Console.WriteLine("Det er det samme ord");
            } else if (word1 != word2) {
                Console.WriteLine("Ordene er ikke ens");

            }
        }

        static void Main(string[] args) {
            // Kald din metode her for at sammenligne to ord.
            CompareWords("Hej", "Hejsa");
            CompareWords("Lasse", "Lasse");
        }
    }
}
