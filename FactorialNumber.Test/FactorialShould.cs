using FactorialNumber.Console;
using FluentAssertions;

namespace FactorialNumber.Test
{
    public class FactorialShould
    {
        [Test]
        public void return_0_when_given_number_is_0()
        {
            var givenNumber = 0;

            var result = Factorial.GetResult(givenNumber);

            result.Should().Be(0);
        }

        [Test]
        public void return_0_when_given_number_is_negative()
        {
            var givenNumber = -7;

            var result = Factorial.GetResult(givenNumber);

            result.Should().Be(0);
        }

        [TestCase(5,120)]
        [TestCase(8,40320)]
        [TestCase(10,3628800)]
        public void return_factorial_when_given_number(int input, long expectedResult)
        {
            var result = Factorial.GetResult(input);

            result.Should().Be(expectedResult);
        }
    }
}