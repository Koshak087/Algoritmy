``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1526 (20H2/October2020Update)
AMD Ryzen 5 5600X, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.404
  [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT


```
| Method |     Mean |   Error |  StdDev |
|------- |---------:|--------:|--------:|
|   Rand | 794.6 μs | 3.34 μs | 3.12 μs |
|  Rand2 | 793.3 μs | 3.47 μs | 3.24 μs |
