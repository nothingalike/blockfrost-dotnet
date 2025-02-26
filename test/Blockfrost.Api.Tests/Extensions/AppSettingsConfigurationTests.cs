﻿using Blockfrost.Api.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Blockfrost.Api.Tests.Extensions
{
    [TestClass]
    [TestCategory(nameof(Blockfrost.Api))]
    [TestCategory(nameof(Blockfrost.Api.Tests.Extensions))]
    public class AppSettingsConfigurationTests : AServiceTestBase
    {

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            ConfigureEnvironment(Constants.PROJECT_NAME_TESTNET);
        }

        [TestMethod]
        [DataRow(Constants.PROJECT_NAME_TESTNET)]
        [DataRow(Constants.PROJECT_NAME_MAINNET)]
        [DataRow(Constants.PROJECT_NAME_IPFS)]
        public void AddAddressService_Configures_Only_AddressService(string projectName)
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();

            // Act
            services.AddAddressService(projectName, CreateTestSpecificConfiguration());

            // Assert
            AssertServiceNetworkConfigured<IAddressService>(projectName, CreateTestSpecificConfiguration(), services);
            foreach (var serviceType in AvailableServiceTypes.Except(new[] { typeof(IAddressService) }))
            {
                AssertServiceNotConfigured(services, serviceType);
            }
        }

        [TestMethod]
        [DataRow(Constants.PROJECT_NAME_TESTNET)]
        [DataRow(Constants.PROJECT_NAME_MAINNET)]
        [DataRow(Constants.PROJECT_NAME_IPFS)]
        public void AddBlockfrost_Configures_All(string projectName)
        {
            // Arrange
            IServiceCollection services = new ServiceCollection();
            IConfiguration config = CreateTestSpecificConfiguration();

            // Act
            services.AddBlockfrost(projectName, config);

            // Assert
            foreach (var serviceType in AvailableServiceTypes)
            {
                AssertServiceNetworkConfigured(projectName, serviceType, config, services);
            }
        }

        private static IConfiguration CreateTestSpecificConfiguration()
        {
            var env = new ConfigurationBuilder()
                .AddJsonFile(Constants.APPSETTINGS_TEST_FILENAME, optional: false, reloadOnChange: true)
                .Build()[Constants.ENV_ENVIRONMENT];

            var config = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            return config;
        }
    }
}
