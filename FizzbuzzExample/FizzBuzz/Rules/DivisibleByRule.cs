namespace FizzBuzz.Rules
{
    public class DivisibleByRule : IRule
    {
        private readonly int _number;
        private readonly string _output;

        public DivisibleByRule(int number, string output)
        {
            _number = number;
            _output = output;
        }

        public string Write(int i)
        {
            return i % _number == 0 ? _output : string.Empty;
        }
    }
}