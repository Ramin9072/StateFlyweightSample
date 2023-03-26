using StateFlyweightSample.Model.Pool;

namespace StateFlyweightSample.Model.States
{
    public abstract class OrderState
    {
        public virtual bool CanConfirm() => true;
        //public virtual OrderState Confirm() => throw new NotSupportedException();
        public virtual OrderState Confirm() => OrderSatePool.GetState<Confirmed>();
    }
}
