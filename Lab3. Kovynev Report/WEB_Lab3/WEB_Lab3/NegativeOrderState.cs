using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    class NegativeOrderState : IStatusState
    {
        public void NextState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже отклонен");

        }
        public void PositiveState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже отклонен");
        }
        public void NegativeState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже отклонен");
        }
        public void RecalledState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже отклонен");
        }
    }
}
