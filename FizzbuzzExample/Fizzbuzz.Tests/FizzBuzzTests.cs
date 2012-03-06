using System.IO;
using FizzBuzz;
using FizzBuzz.Rules;
using NUnit.Framework;

namespace Fizzbuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzzWriter _fizzBuzzWriter;
        private TextWriter _output;

        [SetUp]
        public void Setup()
        {
            _output = new StringWriter();
            _fizzBuzzWriter = new FizzBuzzWriter(_output);
            _fizzBuzzWriter.Configure(new DefaultNumberRule());
            _fizzBuzzWriter.Configure(new DivisibleByRule(3, "Fizz"));
            _fizzBuzzWriter.Configure(new DivisibleByRule(5, "Buzz"));
            _fizzBuzzWriter.Configure(new FizzBuzzRule());
        }

         [Test]
         public void should_write_Fizz_if_number_is_mulitple_of_three()
         {
             _fizzBuzzWriter.WriteLine(3);
             Assert.That(_output.ToString(), Is.EqualTo("Fizz"));
         }

        [Test]
        public void should_write_buzz_if_number_is_multiple_of_five()
        {
            _fizzBuzzWriter.WriteLine(5);
            Assert.That(_output.ToString(), Is.EqualTo("Buzz"));
        }

        [Test]
        public void should_write_fizzbuzz_if_multiple_of_five_and_three()
        {
            _fizzBuzzWriter.WriteLine(15);
            Assert.That(_output.ToString(), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void should_write_number_if_not_multiple()
        {
            _fizzBuzzWriter.WriteLine(1);
            Assert.That(_output.ToString(), Is.EqualTo("1"));
        }

        [Test]
        public void should_be_able_to_configure_new_rules()
        {
            _fizzBuzzWriter.Configure(new DivisibleByRule(4, "bazz"));
            _fizzBuzzWriter.WriteLine(4);
            Assert.That(_output.ToString(), Is.EqualTo("bazz"));
        }
    }
}