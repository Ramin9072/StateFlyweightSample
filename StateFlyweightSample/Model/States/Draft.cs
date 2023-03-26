namespace StateFlyweightSample.Model.States
{
    public class Draft : OrderState
    {
        public override bool CanConfirm()
        {
            return true;
        }
    }
}
