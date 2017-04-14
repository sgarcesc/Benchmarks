``` ini

BenchmarkDotNet=v0.10.3.0, OS=Microsoft Windows 10.0.15063
Processor=Intel(R) Core(TM) i7-6700HQ CPU 2.60GHz, ProcessorCount=8
Frequency=2531248 Hz, Resolution=395.0620 ns, Timer=TSC
dotnet cli version=1.0.1
  [Host]     : .NET Core 4.6.25009.03, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25009.03, 64bit RyuJIT


```
 |       Method |    Elements |      Mean |    StdErr |    StdDev |    Median | Rank | Allocated |
 |------------- |------------ |---------- |---------- |---------- |---------- |----- |---------- |
 |          **Var** | **-2147483648** | **0.0001 ns** | **0.0001 ns** | **0.0005 ns** | **0.0000 ns** |    **1** |       **0 B** |
 | ConcreteType | -2147483648 | 0.0100 ns | 0.0029 ns | 0.0112 ns | 0.0058 ns |    1 |       0 B |
 |          **Var** |           **0** | **0.0464 ns** | **0.0054 ns** | **0.0208 ns** | **0.0504 ns** |    **1** |       **0 B** |
 | ConcreteType |           0 | 0.0594 ns | 0.0101 ns | 0.0391 ns | 0.0547 ns |    1 |       0 B |
 |          **Var** |         **100** | **0.0937 ns** | **0.0170 ns** | **0.0832 ns** | **0.1009 ns** |    **1** |       **0 B** |
 | ConcreteType |         100 | 0.0324 ns | 0.0104 ns | 0.0404 ns | 0.0000 ns |    1 |       0 B |
 |          **Var** |        **1000** | **0.0000 ns** | **0.0000 ns** | **0.0001 ns** | **0.0000 ns** |    **1** |       **0 B** |
 | ConcreteType |        1000 | 0.0407 ns | 0.0104 ns | 0.0403 ns | 0.0267 ns |    1 |       0 B |
 |          **Var** |       **10000** | **0.0177 ns** | **0.0059 ns** | **0.0230 ns** | **0.0116 ns** |    **1** |       **0 B** |
 | ConcreteType |       10000 | 0.0170 ns | 0.0042 ns | 0.0157 ns | 0.0122 ns |    1 |       0 B |
 |          **Var** |      **100000** | **0.0100 ns** | **0.0037 ns** | **0.0144 ns** | **0.0005 ns** |    **1** |       **0 B** |
 | ConcreteType |      100000 | 0.0135 ns | 0.0033 ns | 0.0126 ns | 0.0150 ns |    1 |       0 B |
 |          **Var** |     **1000000** | **0.0138 ns** | **0.0048 ns** | **0.0159 ns** | **0.0048 ns** |    **1** |       **0 B** |
 | ConcreteType |     1000000 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |    1 |       0 B |
 |          **Var** |  **2147483647** | **0.0025 ns** | **0.0014 ns** | **0.0055 ns** | **0.0000 ns** |    **1** |       **0 B** |
 | ConcreteType |  2147483647 | 0.0077 ns | 0.0027 ns | 0.0104 ns | 0.0024 ns |    1 |       0 B |
