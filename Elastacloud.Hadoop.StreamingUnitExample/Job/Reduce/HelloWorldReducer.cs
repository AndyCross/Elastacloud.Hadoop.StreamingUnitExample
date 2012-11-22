using System.Collections.Generic;
using System.Linq;
using Microsoft.Hadoop.MapReduce;

namespace Elastacloud.Hadoop.StreamingUnitExample.Job.Reduce
{
    public class HelloWorldReducer : ReducerCombinerBase
    {
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            context.EmitKeyValue(key, values.Count().ToString());//count instances of this key
        }
    }
}
