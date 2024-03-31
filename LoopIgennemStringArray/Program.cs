namespace LoopIgennemStringArray {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Lord of The Rings:");
            Console.WriteLine();
            string[] filmArray = { "The Fellowship of the Ring", "The Two Towers", "The King Returns" };
            for (int i = 0; i < filmArray.Length; i++) {
                Console.WriteLine(filmArray[i]);
            }
        }
    }
}