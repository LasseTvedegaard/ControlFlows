namespace CelsiusChecker {
    internal class Program {

        public static void CelsiusChecker(int degrees) {
            if (degrees < 0) {
                Console.WriteLine("Det er koldt!");
            } else if (degrees >= 0 && degrees <= 30) {
                Console.WriteLine("Normalt vejr");
            } else if (degrees > 30) {
                Console.WriteLine("Det er meget varmt!");
            }
        }

        static void Main(string[] args) {
            CelsiusChecker(-80);  // Skal udskrive "Det er koldt!"
            CelsiusChecker(20);   // Skal udskrive "Normalt vejr"
            CelsiusChecker(34);   // Skal udskrive "Det er meget varmt!"
        }
    }
}