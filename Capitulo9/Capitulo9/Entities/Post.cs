using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(string title, string content, int likes, List<Comment> comments)
        {
            Moment = DateTime.Now;
            Title = title;
            Content = content;
            Likes = likes;
            Comments = comments;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( $"{Title} \n {Likes} Likes - {Moment} \n  {Content} \n Comments: \n " );
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.ToString());
            }
            return sb.ToString();
        }
    }
}
