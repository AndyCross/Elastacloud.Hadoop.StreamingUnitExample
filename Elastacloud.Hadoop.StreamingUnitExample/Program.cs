using System;
using Elastacloud.Hadoop.StreamingUnitExample.Job.Map;
using Elastacloud.Hadoop.StreamingUnitExample.Job.Reduce;
using Microsoft.Hadoop.MapReduce;

namespace Elastacloud.Hadoop.StreamingUnitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new[]
                {
                    "Hello, Andy",
                    "Hello, andy",
                    "Hello, why doesn't this work!",
                    "Hello, Andy",
                    "Hello, chickenface",
                    "Hello, Andy",
                    "Goodbye, Andy"
                };

            var output =
                    StreamingUnit.Execute<HelloWorldMapper, HelloWorldReducer>(inputArray);

            Console.WriteLine("Map");
            foreach (var mapperResult in output.MapperResult)
            {
                Console.WriteLine(mapperResult);
            }

            Console.WriteLine("MapLog");
            foreach (var mapperLog in output.MapperLog)
            {
                Console.WriteLine(mapperLog);
            }

            Console.WriteLine("Reduce");
            foreach (var reducerResult in output.ReducerResult)
            {
                Console.WriteLine(reducerResult);
            }

            Console.ReadLine();

        }
    }
}
