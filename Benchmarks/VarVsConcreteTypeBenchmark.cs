using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class VarVsConcreteTypeBenchmark
    {
        [Params(int.MinValue, 0, 100, 1000, 10000, 100000, 1000000, int.MaxValue)]
        public int Elements;

        [Benchmark]
        public void Var()
        {
            var stuff = Elements;
        }

        [Benchmark]
        public void ConcreteType()
        {
            int stuff = Elements;
        }
    }
}
