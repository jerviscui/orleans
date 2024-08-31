```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4529/22H2/2022Update)
Intel Xeon CPU E5-2667 v4 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.303
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2


```
| Method                    | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| MessagePackDeserialize    |  40.00 μs | 0.775 μs | 1.230 μs |  1.00 |    0.00 |      - |  11.74 KB |        1.00 |
| ProtobufNetDeserialize    |  83.05 μs | 1.514 μs | 1.416 μs |  2.08 |    0.08 |      - |  11.74 KB |        1.00 |
| SystemTextJsonDeserialize | 121.10 μs | 2.377 μs | 2.107 μs |  3.03 |    0.12 | 0.2441 |  67.62 KB |        5.76 |
| OrleansDeserialize        |  48.62 μs | 0.737 μs | 0.654 μs |  1.22 |    0.05 |      - |  11.74 KB |        1.00 |
