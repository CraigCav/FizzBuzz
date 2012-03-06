using FizzBuzz.Rules;
using NUnit.Framework;

namespace Fizzbuzz.Tests
{
    [TestFixture]
    public class RuleTests
    {
        [Test]
        public void when_divisible_by_four_output_bazz()
        {
            var rule = new DivisibleByRule(4, "bazz");
            Assert.That(rule.Write(4), Is.EqualTo("bazz"));
        }
        
    }
}