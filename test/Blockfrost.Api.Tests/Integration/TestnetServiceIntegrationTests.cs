using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Blockfrost.Api.Tests.Integration
{
    [IntegrationTestClass(nameof(Environments.Staging))]
    [TestCategory(nameof(Blockfrost.Api))]
    [TestCategory(nameof(Blockfrost.Api.Tests.Integration))]
    [TestCategory(Constants.NETWORK_TESTNET)]
    public class TestnetServiceIntegrationTests : AIntegrationTestsBase
    {
        private const string addr_test = "addr_test1qzxug2wcch4gqu6squcx4ffuhsppvrsk7edxv0y0uwqn0xvtcm6l3yfqa9j7swygrgh2k2g7kd7jgvkwxkew2uclhssqgp9f83";

        private const string stake_test = "stake_test1uz9uda0cjyswje0g8zyp5t4t9y0txlfyxt8rtvh9wv0mcgqphtf6d";

        public TestnetServiceIntegrationTests() : base(Constants.API_VERSION)
        {
        }

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            ConfigureEnvironment(Constants.PROJECT_NAME_TESTNET);
        }

        [TestMethod]
        public async Task Service_ApiVersion_Matches_Server_ApiVersion()
        {
            var info = await __service.GetInfoAsync();
            Assert.AreEqual(ApiVersion, info.Version);
            Assert.AreEqual(BaseUrl, info.Url);
        }

        [TestMethod]
        public void Network_Is_Testnet()
        {
            Assert.AreEqual(Constants.NETWORK_TESTNET, __service.Network);
        }
    }
}
