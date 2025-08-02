```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method               | Mean        | Error     | StdDev    | Gen0   | Allocated |
|--------------------- |------------:|----------:|----------:|-------:|----------:|
| VectorArray          | 5,136.38 ns | 44.806 ns | 41.912 ns | 0.0305 |   12024 B |
| ImmutableVectorArray | 5,070.52 ns | 28.365 ns | 26.533 ns | 0.0305 |   12024 B |
| Struct               |    18.36 ns |  0.137 ns |  0.121 ns |      - |         - |
| Class                |    40.17 ns |  0.461 ns |  0.431 ns | 0.0001 |      56 B |
