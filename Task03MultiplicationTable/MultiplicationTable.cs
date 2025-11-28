namespace Task03MultiplicationTable
{
    public class MultiplicationTable
    {
        public static string Run(string inputValue)
        {
            int num = Convert.ToInt32(inputValue);
            string res = string.Empty;

            for (short i = 1; i <= 10; i++)
            {
                res += $"{num} x {i} = {num * i}\n";
            }

            return res + '\n';
        }
    }
}
