using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();

            PrintTitleAndContentInHTMLTags(titleOfArticle, contentOfArticle);

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end of comments")
                {
                    break;
                }

                Console.WriteLine("<div>");
                Console.WriteLine($"\t{command}");
                Console.WriteLine("</div>");
            }

        }

        private static void PrintTitleAndContentInHTMLTags(string titleOfArticle, string contentOfArticle)
        {
            Console.WriteLine("<h1>");
            Console.WriteLine($"\t{titleOfArticle}");
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine($"\t{contentOfArticle}");
            Console.WriteLine("</article>");
        }
    }
}
