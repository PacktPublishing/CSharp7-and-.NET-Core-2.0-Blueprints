using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTwitter.Classes;
using Microsoft.AspNetCore.Mvc;
using Tweetinvi;
using Tweetinvi.Models;

namespace CoreTwitter.Controllers
{
    public class TwitterController : Controller
    {        
        public IActionResult ComposeTweet()
        {            
            return View();
        }
        
        public IActionResult PublishTweet(string tweetText)
        {
            var firstTweet = Tweet.PublishTweet(tweetText);
            
            return RedirectToAction("GetHomeTimeline", "Home"); 
        }
    }
}