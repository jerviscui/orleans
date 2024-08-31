```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method            | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |------------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| Orleans           |    83.42 ns |  1.462 ns |  1.296 ns |  1.00 |    0.00 |      - |         - |          NA |
| Utf8Json          |   348.61 ns |  6.397 ns |  5.671 ns |  4.18 |    0.08 |      - |         - |          NA |
| SystemTextJson    |   754.53 ns |  9.015 ns |  7.992 ns |  9.05 |    0.16 |      - |      56 B |          NA |
| MessagePackCSharp |   112.77 ns |  2.296 ns |  2.036 ns |  1.35 |    0.03 |      - |         - |          NA |
| ProtobufNet       |   265.96 ns |  4.711 ns |  4.407 ns |  3.19 |    0.09 |      - |         - |          NA |
| Hyperion          |   130.71 ns |  1.422 ns |  1.261 ns |  1.57 |    0.03 |      - |      56 B |          NA |
| NewtonsoftJson    | 2,789.05 ns | 47.883 ns | 58.805 ns | 33.57 |    1.00 | 0.0076 |    2856 B |          NA |
| SpanJson          |   243.88 ns |  4.811 ns |  5.540 ns |  2.93 |    0.09 |      - |         - |          NA |
