```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method                    | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| MessagePackDeserialize    | 17.52 μs | 0.160 μs | 0.133 μs |  1.00 |    0.00 | 0.0305 |  11.74 KB |        1.00 |
| ProtobufNetDeserialize    | 31.21 μs | 0.326 μs | 0.305 μs |  1.78 |    0.02 |      - |  11.74 KB |        1.00 |
| SystemTextJsonDeserialize | 72.27 μs | 0.433 μs | 0.405 μs |  4.12 |    0.04 | 0.1221 |  67.65 KB |        5.76 |
| OrleansDeserialize        | 29.35 μs | 0.333 μs | 0.312 μs |  1.68 |    0.02 |      - |  11.74 KB |        1.00 |
