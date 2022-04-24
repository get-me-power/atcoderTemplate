using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
 
class Program
{
    static double[] ReadL() => Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
 
    static (double a, double b) Read2L()
    {
        var a = ReadL();
        return (a[0], a[1]);
    }

    static (double a, double b, double c) Read3L()
    {
        var a = ReadL();
        return (a[0], a[1], a[2]);
    }
 
    /// 階乗を求めるメソッド
    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
 
    static void Main(string[] args)
    {
        Console.WriteLine("Hoge");
    }
}
