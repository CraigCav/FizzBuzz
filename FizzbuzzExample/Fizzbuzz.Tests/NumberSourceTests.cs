using System.Collections.Generic;
using System.Linq;
using FizzBuzz.NumberSource;
using NUnit.Framework;

namespace Fizzbuzz.Tests
{
    [TestFixture]
    public class NumberSourceTests
    {
        readonly OneToOneHundred _source = new OneToOneHundred();

        [Test]
        public void should_provide_a_source_of_numbers_to_iterate_over()
        {
            
            Assert.That(_source, Is.AssignableTo<IEnumerable<int>>());
        }

        [Test]
        public void first_number_to_evaluate_should_be_one()
        {
            Assert.That(_source.First(), Is.EqualTo(1));
        }

        [Test]
        public void first_number_to_evaluate_should_be_two()
        {
            Assert.That(_source.Skip(1).First(), Is.EqualTo(2));
        }

        [Test]
        public void last_number_to_evaluate_should_be_one_hundred()
        {
            Assert.That(_source.Last(), Is.EqualTo(100));
        }
    }
}