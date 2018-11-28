using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    class RecalledOrderState : IStatusState
    {
        public void NextState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта получил новый статус: Отложен");
            order.State = new PostponedOrderState();
        }
        public void PositiveState(Order order)
        {
            Console.WriteLine("Заказ еще не был рассмотрен");
        }
        public void NegativeState(Order order)
        {
            Console.WriteLine("Заказ еще не был рассмотрен");
        }
        public void RecalledState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта уже отозван");
        }
    }
}
