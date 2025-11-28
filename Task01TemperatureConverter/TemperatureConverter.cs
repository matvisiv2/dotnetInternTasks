namespace Task01TemperatureConverter
{
    public class TemperatureConverter
    {
        public static string Run(string inputValue)
        {
            double tCelsium;
            double tFahrenheit;

            tCelsium = Convert.ToDouble(inputValue);

            tFahrenheit = (tCelsium * 9 / 5) + 32;

            return $"{tCelsium}C{(char)176} = {tFahrenheit}F{(char)176}\n";
        }
    }
}
