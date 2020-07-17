using System;

namespace Collection
{
    class Program
    {
        
        public static Forum forum = new Forum();
        public static int newID = 0;
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "7")
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        CreatePost();
                        break;
                    case "2":
                        UpdatePost();
                        break;
                    case "3":
                        RemovePost();
                        break;
                    case "4":
                        ShowPost();
                        break;
                    case "5":
                        Search();
                        break;
                    case "6":
                        Rating();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                        
                }
            }
            
            //{
            //    switch ()
            //    {

            //    }//do
            //} while (true);
        }
        static void CreatePost()
        {
            Console.WriteLine("nhap vao title: ");
            string title = Console.ReadLine();
            Console.WriteLine("nhap content: ");
            string content = Console.ReadLine();
            Console.WriteLine("nhap author: ");
            string author = Console.ReadLine();
            Post vui = new Post(title, content, author);
            newID++;
            vui.Id = newID;
            forum.AddPost(vui);
        }

        static void UpdatePost()
        {
            Console.WriteLine("nhap id can thay doi content: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap content thay doi: ");
            string content = Console.ReadLine();
            forum.Update(id, content);
        }

        static void RemovePost()
        {
            Console.WriteLine("nhap id xoa post: ");
            int id = Convert.ToInt32(Console.ReadLine());
            forum.Remove(id);
        }

        static void ShowPost()
        {
            forum.Show();
        }

        static void Search()
        {
            Console.WriteLine("nhap author: ");
            string author = Console.ReadLine();
            Console.WriteLine("nhap title: ");
            string title = Console.ReadLine();
            forum.FindAuthor(author);
            forum.FindTitle(title);
        }

        static void Rating()
        {
            Console.WriteLine("nhap id vao: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            forum.FindId(Id);
        }

    }
    
}
