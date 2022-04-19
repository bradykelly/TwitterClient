namespace TwitterClient.Cli;

public class TwitterHelper
{
    private readonly ApiSecrets _secrets;
    private Tweetinvi.TwitterClient _client;
    
    public TwitterHelper(ApiSecrets secrets)
    {
        _secrets = secrets;
        _client = new Tweetinvi.TwitterClient(_secrets.ApiKey, _secrets.ApiSecret, _secrets.BearerToken);
    }
}