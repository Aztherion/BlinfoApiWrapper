using System.Threading.Tasks;
using BlInfoApiWrapper.Stores;

namespace BlInfoApiWrapper
{
    public class AuthenticationSession
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private CommonStore _commonStore;

        public string AccessToken { get; private set; }
        public CommonStore CommonStore => _commonStore ?? (_commonStore = new CommonStore());

        public AuthenticationSession(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<bool> Connect()
        {
            if (!string.IsNullOrEmpty(AccessToken)) return true;
            AccessToken = await CommonStore.ConnectAsync(_clientId, _clientSecret);
            return !string.IsNullOrEmpty(AccessToken);
        }
    }
}
