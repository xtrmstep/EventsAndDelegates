using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates1
{
    class Program
    {
        static void Main2(string[] args)
        {
            var a = new A();
            
            A.TypedDelegate d = a.Method;

            Console.ReadKey();
        }
    }

    class A
    {
        public delegate void TypedDelegate(CC c);
        public TypedDelegate tad;

        public void Method(C c)
        {

        }
    }

    class C
    {
        
    }
    class CC : C
    {
        
    }
}
