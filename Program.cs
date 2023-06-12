﻿using BenchmarkDotNet.Running;
using NetPlayground.Tests;

/*
|               Method |      Mean |    Error |   StdDev |
|--------------------- |----------:|---------:|---------:|
|      SumWithForClass |  97.42 us | 1.914 us | 3.548 us |
|     SumWithForStruct |  89.97 us | 0.273 us | 0.242 us |
|  SumWithForeachClass |  93.18 us | 1.485 us | 1.240 us |
| SumWithForeachStruct | 155.12 us | 0.335 us | 0.297 us |
|     SumWithLinqClass | 991.13 us | 5.919 us | 5.537 us |
|    SumWithLinqStruct | 874.54 us | 0.894 us | 0.698 us |
 */
//BenchmarkRunner.Run<EnumerationTests>();

/*
|               Method |       Mean |     Error |    StdDev |
|--------------------- |-----------:|----------:|----------:|
|      GetFirstByIndex |  0.2317 ns | 0.0151 ns | 0.0141 ns |
| GetFirstByEnumerator | 12.1287 ns | 0.2712 ns | 0.3330 ns |
|       GetFirstByLinq |  8.3590 ns | 0.0363 ns | 0.0303 ns | 
 */
//BenchmarkRunner.Run<FirstOrDefaultTests>();

/*
|                        Method |          Mean |         Error |        StdDev |
|------------------------------ |--------------:|--------------:|--------------:|
|                SumWithNewList |      38.35 us |      0.207 us |      0.183 us |
|           SumWithListFromPool | 157,796.15 us | 15,340.665 us | 45,232.296 us |
| SumWithListFromPoolTryFinally | 157,647.85 us | 15,877.483 us | 46,815.117 us |
 */
//BenchmarkRunner.Run<NaivePoolTests>();

/*
|         Method |      Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|--------------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| GenerateRandom |  8.501 ns | 0.0838 ns | 0.0784 ns |  1.00 |    0.00 |      - |         - |          NA |
|   TestToString | 29.426 ns | 0.2643 ns | 0.2473 ns |  3.46 |    0.03 | 0.0019 |      24 B |          NA |
|    TestConvert | 18.026 ns | 0.1717 ns | 0.1522 ns |  2.12 |    0.02 |      - |         - |          NA | 
 */
//BenchmarkRunner.Run<EnumStringVsBoxTests>();