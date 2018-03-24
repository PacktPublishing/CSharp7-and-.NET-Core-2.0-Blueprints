namespace CoreTwitter.Classes
{
    public class CoreTwitterConfiguration
    {
        public string ApplicationName { get; set; }
        public int TweetFeedLimit { get; set; } = 1;
        public TwitterSettings TwitterConfiguration { get; set; } = new TwitterSettings();
    }

    public class TwitterSettings
    {
        public string Consumer_Key { get; set; }
        public string Consumer_Secret { get; set; }
        public string Access_Token { get; set; }
        public string Access_Secret { get; set; }
    }
}
