```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method               | Mean        | Error     | StdDev    | Gen0   | Allocated |
|--------------------- |------------:|----------:|----------:|-------:|----------:|
| VectorArray          | 7,078.21 ns | 68.250 ns | 56.992 ns | 0.0458 |   12024 B |
| ImmutableVectorArray | 7,117.05 ns | 55.873 ns | 52.263 ns | 0.0458 |   12024 B |
| Struct               |    44.20 ns |  0.411 ns |  0.385 ns |      - |         - |
| Class                |    90.90 ns |  1.719 ns |  1.979 ns | 0.0001 |      56 B |
