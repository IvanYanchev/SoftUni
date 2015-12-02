using System;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public abstract class Post :IPost
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }
    }
}
