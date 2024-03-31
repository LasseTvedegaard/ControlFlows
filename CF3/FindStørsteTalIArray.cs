namespace ControlFlow2 {
    public class FindStørsteTalIArray {
        static void Main(string[] args) {

            // This how you find the biggest number in an array
            int[] numbers = { 1, 282, 343, 34, 0, 99, 43, 62, 75, 295 };
            int biggestNo = numbers[0];

            for (int I = 0; I < numbers.Length; I++) {

                if (numbers[I] > biggestNo)
                    biggestNo = numbers[I];
            }
            Console.WriteLine(biggestNo);
        }
    }
}
