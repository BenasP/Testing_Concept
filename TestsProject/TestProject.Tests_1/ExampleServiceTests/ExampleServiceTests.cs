using NUnit.Framework;
using TestsProject;

namespace TestProject.Tests_1.ExampleServiceTests
{
    [TestFixture]
    public class ExampleServiceTests
    {
        protected ExampleService service;
        //TODO add other mock variables related to this service

        [SetUp]
        public void SetUp()
        {
            service = new ExampleService();
        }
    }
}
