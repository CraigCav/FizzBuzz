using System.Collections.Generic;
using System.IO;
using System.Linq;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzzWriter
    {
        private readonly TextWriter _writer;
        private readonly List<IRule> _configuration = new List<IRule>();

        public FizzBuzzWriter(TextWriter output)
        {
            _writer = output;
        }

        public void WriteLine(int i)
        {
            var output = _configuration.Select(x => x.Write(i)).Last(x => !string.IsNullOrEmpty(x));
            _writer.Write(output);
        }

        public void Configure(IRule divisibleByRule)
        {
            _configuration.Add(divisibleByRule);
        }
    }
}