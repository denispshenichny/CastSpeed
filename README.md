BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.404 (1809/October2018Update/Redstone5)
Intel Core i7-3770 CPU 3.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.3928.0), X86 LegacyJIT  [AttachedDebugger]
  DefaultJob : .NET Framework 4.8 (4.8.3928.0), X86 LegacyJIT


|                Method |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|    CastObjects_ToBase | 1.1809 ns | 0.0371 ns | 0.0347 ns |     - |     - |     - |         - |
| CastObjects_ToDerived | 1.1572 ns | 0.0206 ns | 0.0183 ns |     - |     - |     - |         - |
|       CastBase_ToBase | 0.8736 ns | 0.0462 ns | 0.0532 ns |     - |     - |     - |         - |
|    CastBase_ToDerived | 1.1512 ns | 0.0119 ns | 0.0111 ns |     - |     - |     - |         - |
|    CastDerived_ToBase | 0.8799 ns | 0.0526 ns | 0.0605 ns |     - |     - |     - |         - |
| CastDerived_ToDerived | 0.8505 ns | 0.0140 ns | 0.0131 ns |     - |     - |     - |         - |
