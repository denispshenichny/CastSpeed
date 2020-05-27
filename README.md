``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4180.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4180.0), X86 LegacyJIT


```
|                Method |      Mean |     Error |    StdDev |
|---------------------- |----------:|----------:|----------:|
|    CastObjects_ToBase | 4.7773 ns | 0.0161 ns | 0.0151 ns |
| CastObjects_ToDerived | 1.1754 ns | 0.0067 ns | 0.0052 ns |
|       CastBase_ToBase | 0.2397 ns | 0.0071 ns | 0.0067 ns |
|    CastBase_ToDerived | 1.1783 ns | 0.0064 ns | 0.0060 ns |
|    CastDerived_ToBase | 0.2421 ns | 0.0138 ns | 0.0129 ns |
| CastDerived_ToDerived | 0.0601 ns | 0.0080 ns | 0.0075 ns |
