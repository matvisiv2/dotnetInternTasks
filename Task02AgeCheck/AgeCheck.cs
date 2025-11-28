namespace Task02AgeCheck
{
    public class AgeCheck
    {
        public static string Run(string inputValue)
        {
            byte age = Convert.ToByte(inputValue);
            string ageGroup;
            string info = string.Empty;

            if (age < 10)
            {
                ageGroup = "child";
            }
            else if (age < 18)
            {
                ageGroup = "teenager";
            }
            else if (age < 80)
            {
                ageGroup = "adult";
            }
            else
            {
                ageGroup = "adult with respectable age";
            }

            if (age > 122)
            {
                info = "The oldest verified person in human history is Frenchwoman Jeanne Calment, who lived to be 122 years and 164 days old";
            }

            return $"Person with age {age} years is {ageGroup}. {info}\n";
        }

    }
}
