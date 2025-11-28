using System.Text.RegularExpressions;

namespace Task08ShowInfoUsingClassStudent
{
    public class ShowInfoUsingClassStudent
    {
        public static string Run(string inputValue)
        {
            if (string.IsNullOrWhiteSpace(inputValue))
            {
                throw new Exception("you did not enter anything");
            }

            List<Student> students = new List<Student> {
                new Student("Kindrat", "Vyshnevych", 18),
                new Student("Ivasyk",  "Telesyk",    22),
                new Student("Kyrylo",  "Kozhymyaka", 24),
                new Student("Maryan",  "Byk",        19),
                new Student("Oleh",    "Flyak",      20),
                new Student("Mefodiy", "Ornamet",    17)
            };

            switch (inputValue[0])
            {
                case '1':
                    return string.Join('\n', students);
                case '2':
                    Regex regex = new Regex(@"^\d\s([<>|=])(\d+)$");
                    Match match = regex.Match(inputValue);

                    if (!match.Success)
                    {
                        throw new Exception("Incorrect syntax. Correct could be: 2 >20, 2 <20, 2 =20");
                    }

                    char sign = match.Groups[1].Value[0];
                    byte age = Convert.ToByte(match.Groups[2].Value);

                    return sign switch
                    {
                        '>' => string.Join('\n', students.FindAll(student => student.Age > age)),
                        '<' => string.Join('\n', students.FindAll(student => student.Age < age)),
                        '=' => string.Join('\n', students.FindAll(student => student.Age == age)),
                        _ => throw new Exception(),
                    };
                case '3':
                    return students.MaxBy(student => student.Age).ToString();
                default:
                    throw new Exception();
            }
        }

    }
}
