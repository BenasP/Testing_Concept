using NUnit.Framework;
using TestsProject;

namespace TestProject.Tests_1.ExampleServiceTests
{
    [TestFixture]
    public class ExampleServiceTests
    {
        public ExampleService Service;
        //TODO add other mock variables related to this service

        [SetUp]
        public void SetUp()
        {
            Service = new ExampleService();
        }
    }
}
