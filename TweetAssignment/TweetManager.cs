using System;
using System.Collections.Generic;
using System.IO;

namespace TweetAssignment
{
    public static class TweetManager
    {
        private static List<Tweet> Tweets;
        private static string filename;

        static TweetManager()
        {
            Tweets = new List<Tweet>();
            
            TextReader file = new StreamReader("TweetTest.txt");

            string input;

            while ((input = file.ReadLine()) != null)
            {
                Tweets.Add(Tweet.Parse(input));
            }
        }

        //Solely for testing purpose not for production
        public static void Initialize()
        {
            foreach (var tw in Tweets)
            {
                Console.WriteLine(tw); 
            }
        }

        public static void ShowAll()
        {
            foreach (var tw in Tweets)
            {
                Console.WriteLine(tw);
            }
            
        }
        
        public static void ShowAll(string tag)
        {
            foreach (var tw in Tweets)
            {
                if(tw.tag == tag)
                    Console.WriteLine(tw);
            }
        }
        
            
    }
}