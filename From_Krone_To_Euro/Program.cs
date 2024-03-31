namespace From_Krone_to_Euro {
    internal class FromKroneToEuroProgram {

        public static string FromKroneToEuro(double krone) {
            double euro;

            euro = krone * 0.13 + 0.44;

            return $"{krone} kroner is: {euro} Euro";
        }
        static void Main(string[] args) {
            Console.WriteLine(FromKroneToEuro(1));
            Console.WriteLine(FromKroneToEuro(50));
            Console.WriteLine(FromKroneToEuro(100));
            Console.WriteLine(FromKroneToEuro(75));
            Console.WriteLine(FromKroneToEuro(1000));
            Console.WriteLine(FromKroneToEuro(35000));
            Console.WriteLine(FromKroneToEuro(45000));
        }
    }
}