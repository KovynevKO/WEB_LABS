using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    class Order
    {
        public IStatusState State { get; set; }

        public Order(IStatusState ss)
        {
            State = ss;
        }

        public void NextState()
        {
            State.NextState(this);
        }
        public void PositiveState()
        {
            State.PositiveState(this);
        }
        public void NegativeState()
        {
            State.NegativeState(this);
        }
        public void RecalledState()
        {
            State.RecalledState(this);
        }


    }
}
