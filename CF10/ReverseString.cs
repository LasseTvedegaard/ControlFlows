namespace CF10 {
    public class ReverseString {
        public static string Reverse(string input) {

            // Konverter vores input string til et charArray
            char[] charArray = input.ToCharArray();

            // Opret en tom string til at indeholde den inverterede string 
            string reversedString = String.Empty;


            // For loop, der itererer baglæns gennem alle tegnende i input string
            for (int i = charArray.Length - 1; i >= 0; i--) {

                // Tilføj hver eneste tegn fra loop 
                reversedString += charArray[i];

            }

            // Returnerer den inverterede string
            return reversedString;
        }

        static void Main(string[] args) {
            Console.WriteLine(Reverse("Råkost"));
        }

    }
}