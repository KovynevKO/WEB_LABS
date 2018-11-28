using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    class PositiveOrderState : IStatusState
    {
        public void NextState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже утвержден");
        }
        public void PositiveState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже утвержден");
        }
        public void NegativeState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже утвержден");
        }
        public void RecalledState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже утвержден");
        }
    }
}
