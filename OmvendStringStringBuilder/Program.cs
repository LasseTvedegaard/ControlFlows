using System.Text;

namespace OmvendStringStringBuilder {
    internal class Program {
        static void Main(string[] args) {
            string info = "pohslooc";
            StringBuilder result = new StringBuilder();
            foreach (char i in info) {
                result.Insert(0, i);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
