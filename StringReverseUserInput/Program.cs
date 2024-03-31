namespace StringReverseUserInput {
    internal class Program {

        public static string Reverse(string input) {
            char[] lasseString = input.ToCharArray();
            string reversedString = string.Empty;
            for (int i = lasseString.Length - 1; i >= 0; i--) {
                reversedString += lasseString[i];
            }
            return reversedString;
        }

        static void Main(string[] args) {
            Console.WriteLine("Skriv det ord du vil have vendt om");
            string input = Console.ReadLine();
            string Reversed = Reverse(input);
            Console.WriteLine($"Den omvendte dit input er: {Reversed}");
        }
    }
}