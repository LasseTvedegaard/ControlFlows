namespace LeapYear {

    namespace LeapYearChecker {
        class Program {
            static void Main(string[] args) {
                
                Console.WriteLine("Indtast et årstal:");
                int year;
                if (int.TryParse(Console.ReadLine(), out year)) {
                    if (IsLeapYear(year)) {
                        Console.WriteLine($"{year} er et skudår.");
                    } else {
                        Console.WriteLine($"{year} er ikke et skudår.");
                    }
                } else {
                    Console.WriteLine("Indtast venligst et gyldigt årstal.");
                }
            }

            static bool IsLeapYear(int year) {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }
        }
    }
}
