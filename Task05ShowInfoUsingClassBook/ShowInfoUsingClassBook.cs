using System.Text.RegularExpressions;

namespace Task05ShowInfoUsingClassBook
{
    public class ShowInfoUsingClassBook
    {
        public static string Run(string inputValue)
        {
            Regex regex = new Regex(@"^\s*(.+?)\s*,\s*(.+?)\s*,\s*(-*\d{1,4})\s*$");
            Match match = regex.Match(inputValue);

            if (!match.Success)
            {
                throw new Exception("doesn't match");
            }

            string title = match.Groups[1].Value.Trim();
            string author = match.Groups[2].Value.Trim();
            short year = Convert.ToInt16(match.Groups[3].Value.Trim());

            Book book = new(title, author, year);

            return book.GetInfo();
        }
    }
}
