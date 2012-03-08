using System;
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
        private readonly IRule _defaultRule;

        public FizzBuzzWriter(TextWriter output, IRule defaultRule)
        {
            _writer = output;
            _defaultRule = defaultRule;
        }

        public void WriteLine(int i)
        {
            var output = _configuration.Select(x => x.Write(i))
                .Where(x => !string.IsNullOrEmpty(x));

            var result = String.Join(string.Empty, output);

            _writer.Write(string.IsNullOrEmpty(result) ? _defaultRule.Write(i) : result);
        }

        public void Configure(IRule divisibleByRule)
        {
            _configuration.Add(divisibleByRule);
        }
    }
}