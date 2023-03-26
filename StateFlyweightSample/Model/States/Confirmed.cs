namespace StateFlyweightSample.Model.States
{
    public class Confirmed : OrderState
    {
        public override OrderState Confirm()
        {
            return new Confirmed();
        }
    }
}
