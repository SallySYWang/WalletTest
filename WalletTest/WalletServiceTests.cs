using FluentAssertions;
using NUnit.Framework;

namespace WalletTest
{
    public class Tests
    {
        private WalletService _walletService;

        [SetUp]
        public void SetUp()
        {
            _walletService = new WalletService();
        }

        [Test]
        public void should_create_wallet_address()
        {
            var wallet = _walletService.CreateWallet();
            wallet.Address.Should().NotBeNullOrEmpty();

        }
    }
}