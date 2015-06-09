using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionOrEventHandler
{
    /*
     * This example shows the difference of IL for Action and EventHandler
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class A
    {
        public Action<object, EventArgs> Act;

        public void DoAct()
        {
            if (Act != null)
                Act(null, null);
        }
    }

    class B
    {
        public EventHandler Act;

        public void DoAct()
        {
            if (Act != null)
                Act(null, null);
        }

    }

    class C
    {
        public event EventHandler Act;

        public void DoAct()
        {
            if (Act != null)
                Act(null, null);
        }
    }
}
