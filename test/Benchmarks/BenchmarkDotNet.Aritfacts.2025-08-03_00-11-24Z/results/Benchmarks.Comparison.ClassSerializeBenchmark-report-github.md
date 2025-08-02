```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method            | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Payload | Allocated | Alloc Ratio |
|------------------ |----------:|---------:|---------:|------:|--------:|-------:|--------:|----------:|------------:|
| Orleans           |  32.30 ns | 0.293 ns | 0.260 ns |  1.00 |    0.00 |      - |    20 B |         - |          NA |
| Utf8Json          |  69.14 ns | 0.616 ns | 0.546 ns |  2.14 |    0.02 |      - |   154 B |         - |          NA |
| SystemTextJson    | 223.15 ns | 2.621 ns | 2.452 ns |  6.92 |    0.09 |      - |   154 B |         - |          NA |
| MessagePackCSharp |  50.52 ns | 0.743 ns | 0.695 ns |  1.57 |    0.02 | 0.0001 |    10 B |      40 B |          NA |
| ProtobufNet       | 118.31 ns | 1.336 ns | 1.249 ns |  3.66 |    0.05 |      - |    18 B |         - |          NA |
| GoogleProtobuf    |  15.82 ns | 0.225 ns | 0.200 ns |  0.49 |    0.01 |      - |    18 B |         - |          NA |
| Hyperion          |  55.52 ns | 0.475 ns | 0.444 ns |  1.72 |    0.02 |      - |    39 B |         - |          NA |
| NewtonsoftJson    | 505.33 ns | 2.721 ns | 2.412 ns | 15.65 |    0.13 | 0.0048 |   154 B |    2024 B |          NA |
| SpanJson          |  83.30 ns | 0.539 ns | 0.504 ns |  2.58 |    0.02 | 0.0005 |   154 B |     184 B |          NA |
