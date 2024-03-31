namespace ControlFlows {
    public class CF5 {
        static void Main(string[] args) {

            // This is how you sort the array from lowest tog highest

            int[] numbers = { 12, 343, 65, 9, 355, 24, 88, 762, 93 };
            Array.Sort(numbers);
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }


    }
}