namespace Methods_to_Search_a_List_Contains__IndexOf__LastIndexOf_ {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            if (list.Contains(5))   //Returns if the input number is in the list (yes/no)
            {
                Console.WriteLine("Found");

            }

            List<int> list1 = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            if (list1.IndexOf(23) == 5)   //Checks if the number 23 is on index 5
            {
                Console.WriteLine("true");
            }

            List<int> list2 = new List<int>() { 5, 10, 26, 34, 26, 26, 26, 2, 23, 26, 200 };
            if (list2.LastIndexOf(26) == 9)   //Returns if the input number is in the list (yes/no)
            {
                Console.WriteLine("That´s right!");
                Console.WriteLine(list2.LastIndexOf(26));   //Just a an output
            }
        }
    }
}
