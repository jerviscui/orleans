```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method            | Mean        | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |------------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| Orleans           |    50.70 ns | 0.565 ns | 0.528 ns |  1.00 |    0.00 | 0.0001 |      56 B |        1.00 |
| Utf8Json          |   185.51 ns | 2.423 ns | 2.267 ns |  3.66 |    0.06 |      - |      56 B |        1.00 |
| SystemTextJson    |   330.39 ns | 3.658 ns | 3.422 ns |  6.52 |    0.08 |      - |      56 B |        1.00 |
| MessagePackCSharp |    69.71 ns | 0.610 ns | 0.571 ns |  1.37 |    0.02 | 0.0001 |      56 B |        1.00 |
| ProtobufNet       |    53.56 ns | 0.871 ns | 0.815 ns |  1.06 |    0.02 | 0.0001 |      56 B |        1.00 |
| GoogleProtobuf    |    55.25 ns | 0.966 ns | 0.807 ns |  1.09 |    0.01 | 0.0001 |      64 B |        1.14 |
| Hyperion          |    89.85 ns | 0.576 ns | 0.511 ns |  1.77 |    0.02 | 0.0001 |      56 B |        1.00 |
| NewtonsoftJson    | 1,013.32 ns | 8.672 ns | 7.688 ns | 19.99 |    0.24 | 0.0057 |    2856 B |       51.00 |
| SpanJson          |   130.10 ns | 0.802 ns | 0.669 ns |  2.57 |    0.03 |      - |      56 B |        1.00 |
