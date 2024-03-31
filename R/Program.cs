namespace R {

    public class ReverseString {
        // Lav en metode der kan udskrive en string bagfra
        public static string Reverse(string input) {

            char[] charArry = input.ToCharArray();
            // Konverter vores input string til et charArray

            string reversedString = String.Empty;
            // Opret en tom string til at indeholde den inverterede string 

            // For loop, der itererer baglæns gennem alle tegnende i input string
            for (int i = charArry.Length - 1; i >= 0; i--) {

                // Tilføj hver eneste tegn fra loop
                reversedString += charArry[i];
            }


            // Returnerer den inverterede string
            return reversedString;

        }

        static void Main(string[] args) {

            // kald metoden i Main og udskriv resultat
            Console.WriteLine(Reverse("Cola"));
        }

    }
}
