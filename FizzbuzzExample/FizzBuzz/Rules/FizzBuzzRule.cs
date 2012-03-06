namespace FizzBuzz.Rules
{
    public class FizzBuzzRule : IRule
    {
        public string Write(int i)
        {
            return i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : string.Empty;
        }
    }
}