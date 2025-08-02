```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method            | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Payload | Allocated | Alloc Ratio |
|------------------ |----------:|---------:|---------:|------:|--------:|-------:|--------:|----------:|------------:|
| Orleans           |  29.47 ns | 0.410 ns | 0.363 ns |  1.00 |    0.00 |      - |    20 B |         - |          NA |
| Utf8Json          |  60.17 ns | 0.755 ns | 0.669 ns |  2.04 |    0.03 |      - |   154 B |         - |          NA |
| SystemTextJson    | 227.09 ns | 1.921 ns | 1.797 ns |  7.70 |    0.09 |      - |   154 B |      56 B |          NA |
| MessagePackCSharp |  49.51 ns | 0.322 ns | 0.285 ns |  1.68 |    0.02 | 0.0001 |    10 B |      40 B |          NA |
| ProtobufNet       |  91.13 ns | 0.556 ns | 0.465 ns |  3.10 |    0.04 |      - |    18 B |         - |          NA |
| Hyperion          |  69.09 ns | 0.606 ns | 0.567 ns |  2.35 |    0.04 | 0.0001 |    39 B |      56 B |          NA |
| NewtonsoftJson    | 527.53 ns | 6.975 ns | 6.524 ns | 17.92 |    0.32 | 0.0048 |   154 B |    2080 B |          NA |
| SpanJson          |  74.17 ns | 0.803 ns | 0.752 ns |  2.51 |    0.04 | 0.0005 |   154 B |     184 B |          NA |
