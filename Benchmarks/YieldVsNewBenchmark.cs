using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using System.Collections.Generic;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class YieldVsNewBechmark
    {
        [Params(100, 1000, 10000, 100000, 1000000)]
        public int Elements;

        [Benchmark]
        public IEnumerable<int> Yiel()
        {
            for (var i = 0; i < Elements; i++)
            {
                yield return i;
            }
        }

        [Benchmark]
        public IEnumerable<int> New()
        {
            var list = new List<int>();
            for (var i = 0; i < Elements; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
