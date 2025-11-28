namespace Task06MinNumberOfArray
{
    public class MinNumberOfArray
    {
        public static string Run(string inputValue)
        {
            string result = string.Empty;
            int[] numbers;

            if (string.IsNullOrWhiteSpace(inputValue))
            {
                numbers = generateRandomArray();
                result += $"Array is: {ArrayToString(numbers)}\n";
            }
            else
            {
                numbers = inputValue
                    .Replace(" ", "")
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray();
            }

            int res = numbers[0];

            foreach (int i in numbers)
            {
                res = i < res ? i : res;
            }

            result += $"Min number is: {res}";

            return result;
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

        public static string ArrayToString(int[] arr)
        {
            return $"[{string.Join(", ", arr)}]";
        }
    }
}
