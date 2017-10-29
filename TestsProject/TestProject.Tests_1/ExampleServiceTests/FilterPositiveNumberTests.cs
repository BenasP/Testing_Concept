using System.Collections.Generic;
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
    }
}
