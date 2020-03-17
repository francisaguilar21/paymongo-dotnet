using Xunit;

namespace Paymongo.Tests
{
    public class PaymongoClientFactoryTests
    {
        [Fact]
        public void CreateClient_WithDefaultValueInConstructor_ReturnsPaymongoV1ObjectType()
        {
            var expected = typeof(PaymongoV1);
            var actual = new PaymongoClientFactory().CreateClient();

            Assert.IsType(expected, actual);
        }

        [Fact]
        public void CreateClient_WithPaymongoVersionV1InConstructor_ReturnsPaymongoV1ObjectType()
        {
            var expected = typeof(PaymongoV1);
            var actual = new PaymongoClientFactory(PaymongoVersion.V1).CreateClient();

            Assert.IsType(expected, actual);
        }
    }
}
