using System;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

namespace CastSpeed {
    class Program {
        static void Main(string[] args) {
            var result = BenchmarkRunner.Run<Benchmark>(DefaultConfig.Instance
                    .AddDiagnoser(MemoryDiagnoser.Default));
        }
    }
}
