using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Signer;
using Nethereum.Web3.Accounts;

namespace WalletTest
{
    public class WalletService
    {
        public Account CreateWallet()
        {
            var ethEcKey = EthECKey.GenerateKey();
            var privateKey = ethEcKey.GetPrivateKeyAsBytes().ToHex();
            var account = new Account(privateKey);
            return account;
        }
    }
}