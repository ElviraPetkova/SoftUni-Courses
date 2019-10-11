using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticle = new List<Article>();

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] info = Console.ReadLine().Split(", ").ToArray();
                string title = info[0];
                string content = info[1];
                string author = info[2];

                Article oneArticle = new Article()
                {
                    Title = title,
                    Content = content,
                    Author = author
                };

                listOfArticle.Add(oneArticle);
            }

            string input = Console.ReadLine();

            if(input == "title")
            {
                listOfArticle = listOfArticle.OrderBy(t => t.Title).ToList();
            }
            else if(input == "content")
            {
                listOfArticle = listOfArticle.OrderBy(c => c.Content).ToList();
            }
            else if(input == "author")
            {
                listOfArticle = listOfArticle.OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, listOfArticle));
        }
    }
}
