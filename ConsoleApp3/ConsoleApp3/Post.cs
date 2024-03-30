using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description {  get; set; }
        public string CreateDate { get; set; }
        private int score = 0;

       public int Score { get { return score; }}
    
        public Post(string title,string description,string createdate) {
            Title = title;
            Description = description; 
            CreateDate = createdate;
        }

        public void Upvote()
        {
            score++;
        }

        public void Downvote() { score--; }

        public override string ToString()
        {
            return $"Post with title:{Title} create at {CreateDate} has {score}";
        }
    }
}
