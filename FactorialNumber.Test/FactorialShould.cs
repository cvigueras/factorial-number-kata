using FluentAssertions;

namespace FactorialNumber.Test
{
    public class FactorialShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_0_when_given_number_is_0()
        {
            var givenNumber = 0;
            var result = Factorial.GetResult(givenNumber);
            result.Should().Be(0);
        }

        [Test]
        public void return_0_when_given_number_is_null()
        {
            var givenNumber = 0;
            var result = Factorial.GetResult(givenNumber);
            result.Should().Be(0);
        }
    }

    public class Factorial
    {
        public static object GetResult(int givenNumber)
        {
            return 0;
        }
    }
}