using System.Collections.Generic;

namespace WebAPIpoc2.Models
{
    public static class ExampleModel
    {
        public static IEnumerable<string> GetResult()
        {
            return new string[] { "value1", "value2" };
        }
    }
}