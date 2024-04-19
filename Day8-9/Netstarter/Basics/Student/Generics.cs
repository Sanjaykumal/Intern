using System;

public class Generic
{
   
    public void Print<T>(T x)
    {
       Console.WriteLine(x);
    }
    public void Test()
    {
     Print<string>("647667");
      Print<int>(578755);
       Print<decimal>(757.54m);
        Print<byte>(656);

    List<int> marks = []
    marks.Add(89);
    }
}