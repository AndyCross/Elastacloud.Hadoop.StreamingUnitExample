using Elastacloud.Hadoop.StreamingUnitExample.Job.Map;
using Elastacloud.Hadoop.StreamingUnitExample.Job.Reduce;
using Microsoft.Hadoop.MapReduce;

namespace Elastacloud.Hadoop.StreamingUnitExample.Job
{
    public class HelloWorldJob : HadoopJob<HelloWorldMapper, HelloWorldReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            return new HadoopJobConfiguration();//here you would normally set up some input ;-)
        }
    }
}
