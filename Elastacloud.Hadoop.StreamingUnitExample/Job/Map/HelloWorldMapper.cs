using Microsoft.Hadoop.MapReduce;

namespace Elastacloud.Hadoop.StreamingUnitExample.Job.Map
{
    public class HelloWorldMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            //example input: Hello, Andy
            if (!inputLine.StartsWith("Hello, "))
            {
                context.Log(string.Format("The inputLine {0} is not in the correct format", inputLine));
                context.IncrementCounter("RecoverableError", "InputFormatIncorrect", 1);
                return;
            }

            var key = inputLine.Substring(7);
            if (key.EndsWith(".")) key = key.Trim('.');

            context.EmitKeyValue(key, "1");//we are going to count instances, the value is irrelevant
        }
    }
}
