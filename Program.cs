using System;

//int FibOld(int i)
//{
//    if (i <= 2)
//    {
//        return 1;
//    }
//    return FibOld(i - 2) + FibOld(i - 1);
//}

int Fib(int i) =>
    i switch
    {
        int when i <= 2 => 1,
        _ => Fib(i - 2) + Fib(i - 1)
    };

//int FibTail(int n)
//{
//    return Fib(n, 0, 1);
//}

//int Fib(int n, int left, int right)
//{
//    if (n == 0)
//    {
//        return 0;
//    }
//    else if (n == 1)
//    {
//        return right;
//    }
//    else
//    {
//        return Fib(n - 1, right, right + left);
//    }
//}

Console.WriteLine($"43번째: {Fib(43)}");
Console.WriteLine(Fib(43));
Console.WriteLine($"3번째: {Fib(3)}");
