using System;
using System.Runtime.InteropServices;

namespace TweetAssignment
{
    public class Tweet
    {
        //FIELDS 
        private static int current_id;
        
        //PROPERTIES 
        private string from { get; }
        private string to { get; }
        private string body { get; }
        public string tag { get; }
        private string id { get; }
        
        //Methods
        public Tweet(string from ,string to, string body, string tag ) 
        {
            this.from = from;
            this.to = to;
            this.body = body ;
            this.tag = tag;
        }
        
        public Tweet(string from ,string to, string tag, string body, string id) 
        {
            this.from = from;
            this.to = to;
            this.body = body ;
            this.tag = tag;
            this.id = id ;
        }

        public override string ToString()
        {
            return $"Tweet # {id} \n  {from} to @{to} \n\t {body} \n #{tag}";
        }


        public static Tweet  Parse(string line)
        {
            string[] parseLine = line.Split(new char[] {'\t'});
            
            Tweet returnTweet = new Tweet(parseLine[0] , parseLine[1], parseLine[2], parseLine[3], parseLine[4]);

            return returnTweet;
        }
    }
}