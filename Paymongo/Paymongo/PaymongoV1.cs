using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Paymongo.Tests")]
namespace Paymongo
{
    internal sealed class PaymongoV1 : IPaymongo
    {
        public PaymongoV1()
        {
        }
    }
}
