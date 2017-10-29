using System.Collections.Generic;
using System.Linq;

namespace TestsProject
{
    public class ExampleService
    {
        public List<int> FilterPositiveNumbers(List<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0).ToList();
        }
    }
}
