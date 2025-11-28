using System.Text.RegularExpressions;

namespace Task07Calculator
{
    public class Calculator
    {
        public static string Run(string inputValue)
        {
            Regex regex = new Regex(@"^\s*([+-]?\d+(?:,\d+)?)\s*([+\-*/])\s*([+-]?\d+(?:,\d+)?)\s*$");
            Match match = regex.Match(inputValue);

            double a = Convert.ToDouble(match.Groups[1].Value);
            char operation = match.Groups[2].Value[0];
            double b = Convert.ToDouble(match.Groups[3].Value);

            return operation switch
            {
                '+' => $"{a + b}",
                '-' => $"{a - b}",
                '*' => $"{a * b}",
                '/' => $"{a / b}",
                _ => throw new Exception(),
            };
        }
    }
}
