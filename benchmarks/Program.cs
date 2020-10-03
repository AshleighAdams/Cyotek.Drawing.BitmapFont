using BenchmarkDotNet.Running;

// AngelCode bitmap font parsing using C#
// https://www.cyotek.com/blog/angelcode-bitmap-font-parsing-using-csharp

// Copyright © 2017-2020 Cyotek Ltd.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this code useful?
// https://www.paypal.me/cyotek

namespace Benchmarks
{
  internal static class Program
  {
    #region Static Methods

    private static void Main()
    {
      BenchmarkRunner.Run<LoaderBenchmarks>();
    }

    #endregion
  }
}
