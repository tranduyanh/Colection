using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Forum
    {
        public SortedList<int, Post> Posts { get; set; }
        public Forum()
        {
            Posts = new SortedList<int, Post>();
        }
        public void AddPost(Post post)
        {
            Posts.Add(post.Id, post);
        }
        public void Update(int id, string new_Content)
        {
            int post = FindId(id);
            if(post > 0)
            {
                Posts[post].Content = new_Content;
            }
            else
            {
                Console.WriteLine("ID not in list! \"Enter\" to continue...");
                Console.ReadLine();
            }
        }

        public void Remove(int id)
        {
            if (Posts.Count != 0)
            {
                Posts.Remove(id);
            }
            else
            {
                Console.WriteLine("Posts Empty! \"Enter\" to continue...");
                Console.ReadKey();
            }
        }
        public void Show()
        {
            if (Posts.Count != 0)
            {
                foreach (var temp in Posts.Keys)
                {
                    Posts[temp].Display();
                }
            }
            else
            {
                Console.WriteLine("Posts Empty! \"Enter\" to continue...");
                Console.ReadKey();
            }
        }
        public void FindTitle(string title)
        {
            foreach (var temp in Posts.Keys)
            {
                if (Posts[temp].Title == title)
                {
                    Posts[temp].Display();
                }
            }
        }
        public void FindAuthor(string author)
        {
            foreach (var temp in Posts.Keys)
            {
                if (Posts[temp].Author == author)
                {
                    Posts[temp].Display();
                }
            }
        }

        public int FindId(int id)
        {
            foreach (var temp in Posts.Keys)
            {
                if (Posts[temp].Id == id)
                {
                    return id;
                }
            }
            return -1;
        }
    }
}
