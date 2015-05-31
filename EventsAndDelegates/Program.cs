using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.d = new A.ADelegate(a.Method);
            
            a.ad += a.Method;
            a.ad += a.Method;
            a.ad += a.Method;

            A.TypedDelegate d = a.MethodBBCC;

            a.d.DynamicInvoke(null);
            a.ad();

            Console.ReadKey();
        }
    }

    class A
    {
        public delegate void TypedDelegate(C c);
        public delegate void ADelegate();

        public Delegate d;

        public ADelegate ad;
        public TypedDelegate tad;

        public void Method()
        {
            Console.WriteLine("Method");
        }

        public void MethodBBCC(CC c)
        {
            
        }
    }

    class B
    {
        public int N { get; set; }
    }

    class C
    {
        public int N { get; set; }
    }


    class BB:B
    {

    }

    class CC:C
    {
        public int M { get; set; }
    }
}
