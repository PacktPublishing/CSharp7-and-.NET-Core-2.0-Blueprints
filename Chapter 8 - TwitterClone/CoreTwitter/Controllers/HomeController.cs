using CoreTwitter.Classes;
using CoreTwitter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using Tweetinvi;
using Tweetinvi.Models;

namespace CoreTwitter.Controllers
{
    public class HomeController : Controller
    {
        CoreTwitterConfiguration config;

        public HomeController(IOptions<CoreTwitterConfiguration> options)
        {
            config = options.Value;
        }

        public IActionResult Index()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(config.TwitterConfiguration.Access_Token)) throw new Tweetinvi.Exceptions.TwitterNullCredentialsException();
                if (String.IsNullOrWhiteSpace(config.TwitterConfiguration.Access_Secret)) throw new Tweetinvi.Exceptions.TwitterNullCredentialsException();                                
            }
            catch (Tweetinvi.Exceptions.TwitterNullCredentialsException ex)
            {
                return RedirectToAction("AuthenticateTwitter");
            }
            catch (Exception ex)
            {

            }
            return View();
        }


        public IActionResult AuthenticateTwitter()
        {
            var coreTwitterCredentials = new ConsumerCredentials(
                config.TwitterConfiguration.Consumer_Key
                , config.TwitterConfiguration.Consumer_Secret);
            var callbackURL = "http://" + Request.Host.Value + "/Home/ValidateOAuth";
            var authenticationContext = AuthFlow.InitAuthentication(coreTwitterCredentials, callbackURL);

            return new RedirectResult(authenticationContext.AuthorizationURL);
        }



        public ActionResult ValidateOAuth()
        {
            if (Request.Query.ContainsKey("oauth_verifier") && Request.Query.ContainsKey("authorization_id"))
            {
                var oauthVerifier = Request.Query["oauth_verifier"];
                var authId = Request.Query["authorization_id"];

                var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(oauthVerifier, authId);
                var twitterUser = Tweetinvi.User.GetAuthenticatedUser(userCredentials);

                config.TwitterConfiguration.Access_Token = userCredentials.AccessToken;
                config.TwitterConfiguration.Access_Secret = userCredentials.AccessTokenSecret;
                
                ViewBag.User = twitterUser;

            }

            return View();
        }


        public IActionResult GetHomeTimeline()
        {
            TwitterViewModel homeView = new TwitterViewModel();

            try
            {
                if (config.TwitterConfiguration.Access_Token == null) throw new Tweetinvi.Exceptions.TwitterNullCredentialsException();
                if (config.TwitterConfiguration.Access_Secret == null) throw new Tweetinvi.Exceptions.TwitterNullCredentialsException();

                var userCredentials = Auth.CreateCredentials(
                    config.TwitterConfiguration.Consumer_Key
                    , config.TwitterConfiguration.Consumer_Secret
                    , config.TwitterConfiguration.Access_Token
                    , config.TwitterConfiguration.Access_Secret);

                var authenticatedUser = Tweetinvi.User.GetAuthenticatedUser(userCredentials);

                IEnumerable<ITweet> twitterFeed = authenticatedUser.GetHomeTimeline(config.TweetFeedLimit);

                List<TweetItem> tweets = new List<TweetItem>();
                foreach(ITweet tweet in twitterFeed)
                {
                    TweetItem tweetItem = new TweetItem();                    

                    tweetItem.Url = tweet.Url;
                    tweets.Add(tweetItem);
                }

                homeView.HomeTimelineTweets = tweets;                
            }
            catch (Tweetinvi.Exceptions.TwitterNullCredentialsException ex)
            {
                return RedirectToAction("AuthenticateTwitter");
            }
            catch (Exception ex)
            {
                
            }

            return View("Views/Twitter/HomeTimeline.cshtml", homeView);
        }


    }
}
