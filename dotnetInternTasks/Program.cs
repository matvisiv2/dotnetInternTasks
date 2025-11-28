using Task01TemperatureConverter;
using Task02AgeCheck;
using Task03MultiplicationTable;
using Task04SumOfNumbersInRange;
using Task05ShowInfoUsingClassBook;
using Task06MinNumberOfArray;
using Task07Calculator;

namespace dotnetInternTasks
{
    class Program
    {
        static void Main()
        {
            string menuInfo =
                "1. Task01: TemperatureConverter;\n" +
                "2. Task02: AgeCheck;\n" +
                "3. Task03: MultiplicationTable;\n" +
                "4. Task04: SumOfNumbersInRange;\n" +
                "5. Task05: ClassBook;\n" +
                "6. Task06: MinNumberOfArray;\n" +
                "7. Task07: Calculator;\n" +
                "8. Task08: ClassStudent;\n" +
                "c. Clear console;\n" +
                "e. Exit;\n";

            string option;

            do
            {
                Print(FitTitle("Main menu"));
                Print(menuInfo);

                Print("Enter your choice: ");

                option = Console.ReadLine() ?? "";

                if (option.Length == 0 || option.Length > 1)
                {
                    option = "i";
                }

                switch (option[0])
                {
                    case '1':
                        Print(FitTitle("Task01: TemperatureConverter(Celsius to Fahrenheit)"));
                        Print("Tip: You need to enter the temperature in Celsius to convert it to Fahrenheit.\n");
                        TaskCycle(TemperatureConverter.Run);
                        break;
                    case '2':
                        Print(FitTitle("Task02: Age Check"));
                        Print("Tip: You need to enter an age to see which age group the person belongs to.\n");
                        TaskCycle(AgeCheck.Run);
                        break;
                    case '3':
                        Print(FitTitle("Task03: MultiplicationTable"));
                        Print("Tip: You need to enter some number to see its multiplication table.\n");
                        TaskCycle(MultiplicationTable.Run);
                        break;
                    case '4':
                        Print(FitTitle("Task04: SumOfNumbersInRange"));
                        Print("Tip: You need to enter two numbers separated by a comma sign to see the sum in their range.\n");
                        Print("Tip: start value must be less than end value.\n");
                        TaskCycle(SumOfNumbersInRange.Run);
                        break;
                    case '5':
                        Print(FitTitle("Task05: ShowInfoUsingClassBook"));
                        Print("Tip: You need to enter info about book in format: title, author, year.\n");
                        TaskCycle(ShowInfoUsingClassBook.Run);
                        break;
                    case '6':
                        Print(FitTitle("Task06: MinNumberOfArray"));
                        Print("Tip: You need to enter numbers separated by commas or just press enter to autogenerate an array.\n");
                        TaskCycle(MinNumberOfArray.Run);
                        break;
                    case '7':
                        Print(FitTitle("Task07: Calculator"));
                        Print("Tip: You need to enter mathematical expression like (a+b,a-b,a*b,a/b).\n");
                        TaskCycle(Calculator.Run);
                        break;
                    case '8':
                        Print(FitTitle("Task08: ClassStudent"));
                        Print("Tip: enter '1' - to show student list, '2 filter' - to filter, '3' - show the oldest of students.\n");
                        Print(
                            "Tip: 'filter' must be like '20', '>20', '<20':\n" +
                            "  '20' - means students who is 20 years);\n" +
                            "  '<20' - means students who younger than 20);\n" +
                            "  '>20' - means students who older than 20).\n"
                        );
                        //TaskCycle(Task08ClassStudent);
                        break;
                    case 'c':
                        Console.Clear();
                        break;
                    case 'e':
                        break;
                    case 'i':
                    default:
                        Print("Incorrect input. Try again.\n\n");
                        break;
                }
            } while (option[0] != 'e');

            Print("Exit...");
        }

        public static void TaskCycle(Func<string, string> function)
        {
            string inputData;

            do
            {
                Print("Enter value ('c' to clear, 'e' to exit): ");

                try
                {
                    inputData = Console.ReadLine() ?? "";

                    if (inputData.Equals("c"))
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (inputData.Equals("e"))
                    {
                        Print("Back to main menu...\n\n");
                        break;
                    }

                    string result = function(inputData);
                    Print((string.IsNullOrWhiteSpace(result) ? "nothing" : result) + '\n');
                }
                catch (Exception exception)
                {
                    Print(
                        "Incorrect value. Try again.\n" +
                        $"Tip: {exception.Message}\n"
                    );
                }
            } while (true);
        }

        public static void Print(string s)
        {
            Console.Write(s);
        }

        public static string ArrayToString(int[] arr)
        {
            return $"[{string.Join(", ", arr)}]";
        }

        public static string FitTitle(string title)
        {
            return $"-----{title.PadRight(40, '-')}\n";
        }

        public static int[] generateRandomArray()
        {
            Random random = new Random();

            byte length = (byte)random.Next(1, 10);

            int[] res = new int[length];

            for (byte i = 0; i < length; i++)
            {
                res[i] = random.Next(-1000, 1000);
            }

            return res;
        }
    }
};