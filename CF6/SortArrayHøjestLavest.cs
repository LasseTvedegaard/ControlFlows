namespace ControlFlows {
    public class SortArrayHøjestLavest {
        static void Main(string[] args) {

            // This is how you sort the array from highest to lowest

            int[] numbers = { 1, 343, 65, 9, 355, 24, 88, 762, 93 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }


    }
}