```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method            | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |------------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| Orleans           |    31.46 ns |  0.244 ns |  0.228 ns |  1.00 |    0.00 |      - |         - |          NA |
| Utf8Json          |   178.03 ns |  0.656 ns |  0.613 ns |  5.66 |    0.04 |      - |         - |          NA |
| SystemTextJson    |   298.49 ns |  2.738 ns |  2.561 ns |  9.49 |    0.11 |      - |      56 B |          NA |
| MessagePackCSharp |    59.74 ns |  0.721 ns |  0.639 ns |  1.90 |    0.03 |      - |         - |          NA |
| ProtobufNet       |   120.10 ns |  1.222 ns |  1.143 ns |  3.82 |    0.05 |      - |         - |          NA |
| Hyperion          |    73.80 ns |  0.313 ns |  0.277 ns |  2.35 |    0.02 | 0.0001 |      56 B |          NA |
| NewtonsoftJson    | 1,108.09 ns | 15.431 ns | 13.679 ns | 35.23 |    0.54 | 0.0057 |    2856 B |          NA |
| SpanJson          |   124.55 ns |  1.338 ns |  1.251 ns |  3.96 |    0.06 |      - |         - |          NA |
