```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.6093/22H2/2022Update)
12th Gen Intel Core i7-12800HX, 1 CPU, 24 logical and 16 physical cores
.NET SDK 9.0.301
  [Host]     : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.17 (8.0.1725.26602), X64 RyuJIT AVX2


```
| Method                     | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|--------------------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| OrleansPipeWriter          | 19.138 μs | 0.1535 μs | 0.1361 μs |     ? |       ? |      - |     480 B |           ? |
|                            |           |           |           |       |         |        |           |             |
| MessagePackSerialize       |  8.353 μs | 0.0989 μs | 0.0925 μs |  1.00 |    0.00 | 0.0305 |   16032 B |        1.00 |
| ProtobufNetSerialize       | 28.242 μs | 0.3381 μs | 0.2997 μs |  3.38 |    0.05 | 0.0305 |   17024 B |        1.06 |
| SystemTextJsonSerialize    | 44.015 μs | 0.4175 μs | 0.3905 μs |  5.27 |    0.07 | 0.1221 |   49488 B |        3.09 |
| OrleansSerialize           | 11.417 μs | 0.1136 μs | 0.1062 μs |  1.37 |    0.02 | 0.0305 |   17032 B |        1.06 |
|                            |           |           |           |       |         |        |           |             |
| MessagePackBufferWriter    |  6.844 μs | 0.0457 μs | 0.0428 μs |  1.00 |    0.00 |      - |         - |          NA |
| ProtobufNetBufferWriter    | 36.376 μs | 0.2862 μs | 0.2537 μs |  5.31 |    0.06 |      - |         - |          NA |
| SystemTextJsonBufferWriter | 43.512 μs | 0.4444 μs | 0.4156 μs |  6.36 |    0.06 | 0.0610 |   32312 B |          NA |
| OrleansBufferWriter        |  9.523 μs | 0.0686 μs | 0.0641 μs |  1.39 |    0.01 |      - |         - |          NA |
| OrleansBufferWriter2       | 19.906 μs | 0.1962 μs | 0.1835 μs |  2.91 |    0.04 |      - |         - |          NA |
