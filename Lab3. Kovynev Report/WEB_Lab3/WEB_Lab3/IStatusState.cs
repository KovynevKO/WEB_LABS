using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    interface IStatusState
    {
        void NextState(Order order);
        void PositiveState(Order order);
        void NegativeState(Order order);
        void RecalledState(Order order);
    }
}
