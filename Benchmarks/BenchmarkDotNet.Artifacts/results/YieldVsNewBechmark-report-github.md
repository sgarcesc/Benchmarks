``` ini

BenchmarkDotNet=v0.10.3.0, OS=Microsoft Windows 10.0.15063
Processor=Intel(R) Core(TM) i7-6700HQ CPU 2.60GHz, ProcessorCount=8
Frequency=2531248 Hz, Resolution=395.0620 ns, Timer=TSC
dotnet cli version=1.0.1
  [Host]     : .NET Core 4.6.25009.03, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25009.03, 64bit RyuJIT


```
 | Method | Elements |              Mean |         StdErr |          StdDev |            Median | Rank |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
 |------- |--------- |------------------ |--------------- |---------------- |------------------ |----- |--------- |--------- |--------- |---------- |
 |   **Yiel** |      **100** |         **9.9308 ns** |      **0.1564 ns** |       **1.0255 ns** |         **9.6826 ns** |    **4** |   **0.0119** |        **-** |        **-** |      **40 B** |
 |    New |      100 |       598.0073 ns |      3.2491 ns |      12.5838 ns |       596.2830 ns |    5 |   0.3558 |        - |        - |   1.19 kB |
 |   **Yiel** |     **1000** |         **9.3292 ns** |      **0.0773 ns** |       **0.2995 ns** |         **9.3381 ns** |    **3** |   **0.0119** |        **-** |        **-** |      **40 B** |
 |    New |     1000 |     4,142.6911 ns |     23.7387 ns |      91.9398 ns |     4,139.6774 ns |    6 |   2.5075 |        - |        - |   8.41 kB |
 |   **Yiel** |    **10000** |         **7.9609 ns** |      **0.1367 ns** |       **0.7855 ns** |         **7.6735 ns** |    **1** |   **0.0119** |        **-** |        **-** |      **40 B** |
 |    New |    10000 |    37,996.5216 ns |     86.7576 ns |     324.6171 ns |    38,074.0921 ns |    7 |  40.3239 |        - |        - | 131.32 kB |
 |   **Yiel** |   **100000** |         **8.5246 ns** |      **0.1443 ns** |       **0.6289 ns** |         **8.4945 ns** |    **2** |   **0.0119** |        **-** |        **-** |      **40 B** |
 |    New |   100000 |   440,454.6967 ns |  4,394.5064 ns |  35,429.6435 ns |   424,320.1398 ns |    8 | 266.9271 | 266.9271 | 266.9271 |   1.05 MB |
 |   **Yiel** |  **1000000** |         **8.0445 ns** |      **0.1351 ns** |       **0.5731 ns** |         **7.9895 ns** |    **1** |   **0.0119** |        **-** |        **-** |      **40 B** |
 |    New |  1000000 | 6,185,077.2121 ns | 44,174.8475 ns | 171,088.4488 ns | 6,137,870.5905 ns |    9 | 282.8947 | 251.6447 | 251.6447 |   7.68 MB |
