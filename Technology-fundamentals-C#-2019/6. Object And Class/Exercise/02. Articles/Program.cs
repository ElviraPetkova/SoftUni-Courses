using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Editing(string oldContent, string newContent)
        {
            oldContent = Content;
            Content = null;
            Content = newContent;

            return Content;
        }

        public string ChangeAuthor(string oldAuthorName, string newAuthorName)
        {
            oldAuthorName = Author;
            Author = newAuthorName;

            return Author;
        }

        public string Rename(string oldName, string newName)
        {
            oldName = Title;
            Title = newName;

            return Title;
        }

        public string ToStringArticle()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
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

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] line = Console.ReadLine().Split(": ");
                string command = line[0];

                if(command == "Edit")
                {
                    string newContent = line[1];
                    oneArticle.Editing(oneArticle.Content, newContent);
                }
                else if(command == "ChangeAuthor")
                {
                    string newNameAuthor = line[1];
                    oneArticle.ChangeAuthor(oneArticle.Author, newNameAuthor);
                }
                else if(command == "Rename")
                {
                    string newTitle = line[1];
                    oneArticle.Rename(oneArticle.Title, newTitle);
                }
            }

            string result = oneArticle.ToStringArticle();

            Console.WriteLine(result);
        }
    }
}
