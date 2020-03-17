namespace Paymongo
{
    public class PaymongoClientFactory
    {
        private readonly PaymongoVersion version;

        public PaymongoClientFactory(PaymongoVersion version = PaymongoVersion.V1)
        {
            this.version = version;
        }

        public IPaymongo CreateClient()
        {
            return new PaymongoV1();
        }
    }
}
