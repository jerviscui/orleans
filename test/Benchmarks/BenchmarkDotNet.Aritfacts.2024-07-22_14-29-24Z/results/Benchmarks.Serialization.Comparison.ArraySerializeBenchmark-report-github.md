```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method                     | Mean     | Error    | StdDev    | Median   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|--------------------------- |---------:|---------:|----------:|---------:|------:|--------:|-------:|----------:|------------:|
| OrleansPipeWriter          | 46.86 μs | 0.632 μs |  0.591 μs | 46.78 μs |     ? |       ? |      - |     480 B |           ? |
|                            |          |          |           |          |       |         |        |           |             |
| MessagePackSerialize       | 19.52 μs | 0.381 μs |  0.391 μs | 19.45 μs |  1.00 |    0.00 | 0.0610 |   16032 B |        1.00 |
| ProtobufNetSerialize       | 63.61 μs | 1.083 μs |  0.905 μs | 63.40 μs |  3.28 |    0.06 |      - |   17024 B |        1.06 |
| SystemTextJsonSerialize    | 71.72 μs | 1.307 μs |  1.159 μs | 71.70 μs |  3.69 |    0.09 | 0.1221 |   49488 B |        3.09 |
| OrleansSerialize           | 26.82 μs | 0.508 μs |  0.499 μs | 26.58 μs |  1.38 |    0.03 | 0.0610 |   17032 B |        1.06 |
|                            |          |          |           |          |       |         |        |           |             |
| MessagePackBufferWriter    | 16.38 μs | 0.315 μs |  0.309 μs | 16.26 μs |  1.00 |    0.00 |      - |         - |          NA |
| ProtobufNetBufferWriter    | 97.64 μs | 5.766 μs | 16.728 μs | 90.63 μs |  6.19 |    1.25 |      - |         - |          NA |
| SystemTextJsonBufferWriter | 71.85 μs | 1.390 μs |  1.544 μs | 71.52 μs |  4.38 |    0.13 | 0.1221 |   32312 B |          NA |
| OrleansBufferWriter        | 23.58 μs | 0.353 μs |  0.295 μs | 23.62 μs |  1.44 |    0.03 |      - |         - |          NA |
| OrleansBufferWriter2       | 44.74 μs | 0.840 μs |  0.933 μs | 44.37 μs |  2.73 |    0.07 |      - |         - |          NA |
