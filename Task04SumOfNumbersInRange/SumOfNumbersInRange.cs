using System.Text.RegularExpressions;

namespace Task04SumOfNumbersInRange
{
    public class SumOfNumbersInRange
    {
        public static string Run(string inputValue)
        {
            Regex regex = new Regex(@"^\s*(-?\d+)\s*,\s*(-?\d+)\s*$");
            Match match = regex.Match(inputValue);

            int start = int.Parse(match.Groups[1].Value);
            int end = int.Parse(match.Groups[2].Value);

            if (start >= end)
            {
                throw new Exception();
            }

            int[] range = Enumerable.Range(start, end - start + 1).ToArray();

            return $"sum({start}, {end}) = {range.Sum()}\n";
        }

    }
}
