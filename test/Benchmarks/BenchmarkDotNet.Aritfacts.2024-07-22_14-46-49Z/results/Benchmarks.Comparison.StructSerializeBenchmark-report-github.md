```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method            | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Payload | Allocated | Alloc Ratio |
|------------------ |------------:|----------:|----------:|------:|--------:|-------:|--------:|----------:|------------:|
| Orleans           |    74.48 ns |  1.525 ns |  2.283 ns |  1.00 |    0.00 |      - |    20 B |         - |          NA |
| Utf8Json          |   146.61 ns |  2.915 ns |  3.470 ns |  1.96 |    0.08 |      - |   154 B |         - |          NA |
| SystemTextJson    |   376.48 ns |  4.998 ns |  3.902 ns |  5.07 |    0.15 |      - |   154 B |      56 B |          NA |
| MessagePackCSharp |    89.20 ns |  1.151 ns |  1.076 ns |  1.20 |    0.04 | 0.0001 |    10 B |      40 B |          NA |
| ProtobufNet       |   225.24 ns |  4.368 ns |  4.086 ns |  3.02 |    0.12 |      - |    18 B |         - |          NA |
| Hyperion          |   147.33 ns |  2.352 ns |  2.085 ns |  1.98 |    0.08 |      - |    39 B |      56 B |          NA |
| NewtonsoftJson    | 1,252.78 ns | 19.420 ns | 21.586 ns | 16.81 |    0.52 | 0.0076 |   154 B |    2080 B |          NA |
| SpanJson          |   189.42 ns |  1.610 ns |  1.428 ns |  2.54 |    0.07 | 0.0007 |   154 B |     184 B |          NA |
