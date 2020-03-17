using Xunit;

namespace Paymongo.Tests
{
    public class PaymongoVersionExtensions
    {
        [Fact]
        public void ToLowerString_WithPaymongoVersionV1_Returnsv1String()
        {
            var expected = "v1";
            var actual = PaymongoVersion.V1.ToLowerString();

            Assert.Equal(expected, actual);
        }
    }
}
