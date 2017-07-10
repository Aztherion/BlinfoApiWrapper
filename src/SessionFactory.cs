namespace BlInfoApiWrapper
{
    public class SessionFactory
    {
        public static AuthenticationSession GetAuthenticationSession(string clientId, string clientSecret)
        {
            return new AuthenticationSession(clientId, clientSecret);
        }

        public static ClientSession GetClientSession(AuthenticationSession authenticationSession, string clientPublicKey)
        {
            return new ClientSession(authenticationSession, clientPublicKey);
        }
    }
}
