using System.Globalization;

namespace FizzBuzz.Rules
{
    public class DefaultNumberRule : IRule
    {
        public string Write(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}