using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject.Tests_1.ExampleServiceTests
{
    [TestFixture]
    public class FilterPositiveNumberTests : ExampleServiceTests
    {
        private List<int> numbers;

        [SetUp]
        public void MethodSetUp()
        {
            numbers = new List<int>();
        }

        [Test]
        public void ShouldReturnIntType()
        {
            var result = service.FilterPositiveNumbers(numbers);

            result.Should().BeOfType(typeof(List<int>));
        }
    }
}
