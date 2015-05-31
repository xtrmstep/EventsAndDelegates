using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal delegate void MethodDelegate(int v);

    class A
    {

        public event MethodDelegate MethodEvent;
        public MethodDelegate Method;

        public virtual void OnMethodEvent(int v)
        {
            var handler = MethodEvent;
            if (handler != null) handler(v);
        }
    }

    class Program
    {
        static void M(int a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            /*
             * 1) компилятор разрешает вызывать евенты напрямую только внутри самого класса
             * 2) в IL для евента создается больше "умного" кода
             */
            var a = new A();
            a.Method += M;
            a.MethodEvent += M;

            Console.WriteLine("Method is assigned");
            a.Method(1);
            a.OnMethodEvent(2);

            Console.ReadKey();
        }
    }
}
