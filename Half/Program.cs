namespace Half {
    public class Program {
        static void Main(string[] args) {
            int sum = 0;

            int[] numbers = { 49, 36, 4, 62, 726, 54, 89, 66 };

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];

            }
            int half = sum / 2;

            Console.WriteLine(half);
        }
    }
}