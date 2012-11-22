using Microsoft.Hadoop.MapReduce;

namespace Elastacloud.Hadoop.StreamingUnitExample.Job.Map
{
    public class HelloWorldMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            //example input: Hello, Andy
            if (!inputLine.StartsWith("Hello, ")) return;

            var key = inputLine.Substring(7);
            if (key.EndsWith(".")) key = key.Trim('.');

            context.EmitKeyValue(key, "1");//we are going to count instances, the value is irrelevant
        }
    }
}
