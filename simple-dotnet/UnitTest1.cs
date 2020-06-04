using Newtonsoft.Json;

namespace simple_dotnet
{
    public class UnitTest1
    {
        public static void Main()
        {
            JsonConvert.DeserializeObject<object>("{ 'hello': 'world' }");
        }
    }
}
