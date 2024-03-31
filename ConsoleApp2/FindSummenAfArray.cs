namespace ControlFlow2 {
    public class FindSummenAfArray {
        static void Main(string[] args) {

            // This is how you find the sum of the array
            int sum = 0;
            int[] numbers = { 1, 982, 343, 63, 81, 90, 4, 62, 75, 245 };

            for (int I = 0; I < numbers.Length; I++) {
                sum += numbers[I];
                Console.WriteLine($"summen af tallene er {sum}");
            }
        }
    }
}