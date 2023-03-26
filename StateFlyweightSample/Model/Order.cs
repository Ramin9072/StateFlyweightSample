using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateFlyweightSample.Model.Pool;
using StateFlyweightSample.Model.States;

namespace StateFlyweightSample.Model
{
    public class Order
    {
        public OrderState State { get; private set; }

        public Order()
        {
            //this.State = new Draft();
            this.State = OrderSatePool.GetState<Draft>();
        }

        public void Confirm() 
        {
            if (State.CanConfirm())
                State = State.Confirm();
        }
    }
}
