```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method            | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Payload | Allocated | Alloc Ratio |
|------------------ |------------:|----------:|----------:|------:|--------:|-------:|--------:|----------:|------------:|
| Orleans           |    85.39 ns |  1.735 ns |  1.856 ns |  1.00 |    0.00 |      - |    20 B |         - |          NA |
| Utf8Json          |   165.62 ns |  2.914 ns |  2.726 ns |  1.94 |    0.06 |      - |   154 B |         - |          NA |
| SystemTextJson    |   375.32 ns |  7.508 ns |  8.345 ns |  4.40 |    0.16 |      - |   154 B |         - |          NA |
| MessagePackCSharp |    99.17 ns |  1.845 ns |  1.635 ns |  1.16 |    0.03 | 0.0001 |    10 B |      40 B |          NA |
| ProtobufNet       |   273.46 ns |  4.415 ns |  3.686 ns |  3.21 |    0.06 |      - |    18 B |         - |          NA |
| GoogleProtobuf    |    47.18 ns |  0.927 ns |  0.867 ns |  0.55 |    0.02 |      - |    18 B |         - |          NA |
| Hyperion          |   128.74 ns |  2.597 ns |  2.550 ns |  1.51 |    0.04 |      - |    39 B |         - |          NA |
| NewtonsoftJson    | 1,259.69 ns | 16.768 ns | 14.865 ns | 14.79 |    0.29 | 0.0076 |   154 B |    2024 B |          NA |
| SpanJson          |   208.70 ns |  4.073 ns |  5.437 ns |  2.45 |    0.09 | 0.0007 |   154 B |     184 B |          NA |
