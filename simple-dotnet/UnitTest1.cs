using System;
using Xunit;
using Newtonsoft.Json;

namespace simple_dotnet
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            JsonConvert.DeserializeObject<object>("{ 'hello': 'world' }");
        }
    }
}
