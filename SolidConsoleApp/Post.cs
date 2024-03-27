using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsoleApp
{
    public class Post
    {
       public virtual void CreatePost(string postMessage)
        {
            Console.WriteLine("The Post message {0)added to DB. Method 'CreatePost' in Class Post", postMessage);
        }
    }

    public class TagPost:Post
    {
       public override void CreatePost( string postMessage)
        {
            Console.WriteLine("The Post message {0)added to DB. Method 'CreatePost' in Class TagPost", postMessage);
        }
    }

    public class MentionPost : Post
    {
        void CreateMentionPost( string postMessage)
        {
            base.CreatePost(postMessage);
        }
    }
}
