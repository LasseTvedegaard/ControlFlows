namespace ControlFlow2 {
    public class FindMindsteTalIArray {
        static void Main(string[] args) {

            // This how you find the smallest number in an array
            int[] numbers = { 43, 282, 343, 34, 78, 99, 43, 62, 75, 295 };
            int smallestNo = numbers[0];

            for (int I = 0; I < numbers.Length; I++) {

                if (numbers[I] < smallestNo)
                    smallestNo = numbers[I];
            }
            Console.WriteLine(smallestNo);
        }
    }
}