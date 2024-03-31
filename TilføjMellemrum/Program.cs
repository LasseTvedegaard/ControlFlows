using System.Text;

namespace TilføjMellemrum {
    internal class Program {
        static void Main(string[] args) {
            string name = "LasseTvedegaardNyboe";
            StringBuilder result = new StringBuilder();
            foreach (char c in name) {
                if (char.IsUpper(c) && result.Length > 0) {

                    result.Append(" ");

                }
                result.Append(c);

            }
            Console.WriteLine(result.ToString());

        }
    }
}
