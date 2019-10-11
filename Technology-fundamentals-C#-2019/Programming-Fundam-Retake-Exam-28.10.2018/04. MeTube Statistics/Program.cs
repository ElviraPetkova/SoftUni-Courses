using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MeTube_Statistics
{
    class Video
    {
        public string Name { get; set; }

        public int Views { get; set; }

        public int Likes { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var meTube = new Dictionary<string, Video>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "stats time")
                {
                    break;
                }

                if (input.Contains('-'))
                {
                    string[] tokens = input.Split('-');
                    string videoName = tokens[0];
                    int views = int.Parse(tokens[1]);

                    if(meTube.ContainsKey(videoName) == false)
                    {
                        Video currentVideo = new Video()
                        {
                            Name = videoName,
                            Views = views,
                            Likes = 0
                        };

                        meTube.Add(videoName, currentVideo);
                    }
                    else
                    {
                        meTube[videoName].Views += views;
                    }
                }
                else if (input.Contains(':'))
                {
                    string[] tokens = input.Split(':');
                    string contidion = tokens[0];
                    string nameOfVideo = tokens[1];

                    if(contidion == "like")
                    {
                        if (meTube.ContainsKey(nameOfVideo))
                        {
                            meTube[nameOfVideo].Likes++;
                        }
                    }
                    else if(contidion == "dislike")
                    {
                        if (meTube.ContainsKey(nameOfVideo))
                        {
                            meTube[nameOfVideo].Likes--;
                        }
                    }
                }
            }

            string[] command = Console.ReadLine().Split();
            string criterion = command[1];
            if(criterion == "likes")
            {
                var result = meTube.OrderByDescending(x => x.Value.Likes).ToList();
                foreach (var kvp in result)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value.Views} views - {kvp.Value.Likes} likes");
                }
            }
            else if(criterion == "views")
            {
                var result = meTube.OrderByDescending(x => x.Value.Views).ToList();
                foreach (var kvp in result)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value.Views} views - {kvp.Value.Likes} likes");
                }
            }
        }
    }
}
