```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method            | Mean       | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |-----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| Orleans           |   121.1 ns |  2.42 ns |  2.15 ns |  1.00 |    0.00 |      - |      56 B |        1.00 |
| Utf8Json          |   377.1 ns |  7.55 ns |  8.08 ns |  3.13 |    0.09 |      - |      56 B |        1.00 |
| SystemTextJson    |   895.7 ns | 17.57 ns | 20.91 ns |  7.37 |    0.18 |      - |      56 B |        1.00 |
| MessagePackCSharp |   130.9 ns |  2.50 ns |  4.11 ns |  1.10 |    0.04 |      - |      56 B |        1.00 |
| ProtobufNet       |   133.3 ns |  2.67 ns |  4.00 ns |  1.09 |    0.04 |      - |      56 B |        1.00 |
| GoogleProtobuf    |   111.3 ns |  2.21 ns |  2.27 ns |  0.92 |    0.03 | 0.0002 |      64 B |        1.14 |
| Hyperion          |   177.2 ns |  2.74 ns |  2.43 ns |  1.46 |    0.03 |      - |      56 B |        1.00 |
| NewtonsoftJson    | 2,509.5 ns | 45.83 ns | 56.28 ns | 20.78 |    0.53 | 0.0076 |    2856 B |       51.00 |
| SpanJson          |   267.9 ns |  5.08 ns |  4.50 ns |  2.21 |    0.06 |      - |      56 B |        1.00 |
