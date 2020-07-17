using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Post : IPost 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; set; }
        public int count = 3;
        public int[] Ratelist = new int[3];
        public const int MINRATING = 1;
        public const int MAXRATING = 5;


        public void Display()
        {
            Console.WriteLine($"Title: {Title} \t Content: {Content} \t Author: {Author} \t AverageRate: {AverageRate}");
        }

        public Post(string Title, string Content, string Author)
        {
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;

        }
        
        public int this [int index]
        {
            get { return Ratelist[index]; }

            set { Ratelist[index] = value; }
        }

        public void CalculatorRate()
        {
            float total = 0;
            foreach (var item in Ratelist)
            {
                total += item;
            }
            AverageRate =(float)Math.Round(total / Ratelist.Length, 1);
        }

    }
}
