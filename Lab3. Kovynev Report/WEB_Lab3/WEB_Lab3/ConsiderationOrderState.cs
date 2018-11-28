using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Lab3
{
    class ConsiderationOrderState : IStatusState
    {
        public void NextState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта ждет утверждения");
            
        }
        public void PositiveState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта утвержден");
            order.State = new PositiveOrderState();
        }
        public void NegativeState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта отклонен");
            order.State = new NegativeOrderState();
        }
        public void RecalledState(Order order)
        {
            Console.WriteLine("Заказ на получние гаранта  получил новый статус: Отозван");
            order.State = new RecalledOrderState();
        }
    }
}
