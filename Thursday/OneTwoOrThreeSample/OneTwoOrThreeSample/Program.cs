using System;

namespace OneTwoOrThreeSample
{
    public ref struct MyStruct
    {

    }

    public class X
    {
        public int A;
    }

    class Program
    {
        static void ChangeX(ref X x1)
        {
            x1.A = 2;

            x1 = new X();
            x1.A = 3;
        }

        static void Main(string[] args)
        {
            X x = new X();
            x.A = 1;
            ChangeX(ref x);
            Console.WriteLine(x.A);

            int x1 = 3;
            object o = x;  // boxing

            x1 = (int)o;  // unboxing
            DoSomething(x1);
        }

        static void DoSomething(object o1)
        {

        }

        public static void UseSpan()
        {
            Span<int> mySpan = new Span<int>();

        }
    }
}
