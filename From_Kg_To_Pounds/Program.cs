namespace From_Kg_to_Pounds {
    internal class FromKgToPoundsProgram {
        public static string FromKgToPounds(double kg) {
            double pounds;

            pounds = kg * 2 + 0.20;

            return $"{kg} kg is: ({pounds} pounds)";
        }
        static void Main(string[] args) {
            Console.WriteLine(FromKgToPounds(1));
            Console.WriteLine(FromKgToPounds(5));
            Console.WriteLine(FromKgToPounds(83));
            Console.WriteLine(FromKgToPounds(100));

        }
    }
}