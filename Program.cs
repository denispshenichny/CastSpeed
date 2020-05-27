using System;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace CastSpeed {
    class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<Benchmark>(DefaultConfig.Instance);
        }
    }
}
