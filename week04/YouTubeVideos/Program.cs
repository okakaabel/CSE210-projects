using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Video 1
            Video v1 = new Video("Learning C# in 10 Minutes", "CodeMaster", 600);
            v1.AddComment(new Comment("Alice", "Great tutorial!"));
            v1.AddComment(new Comment("Bob", "This helped me a lot, thanks."));
            v1.AddComment(new Comment("Charlie", "Can you make one for Python?"));
            videos.Add(v1);

            // Video 2
            Video v2 = new Video("Top 10 Travel Destinations 2026", "Wanderlust", 945);
            v2.AddComment(new Comment("Dave", "I want to go to Japan!"));
            v2.AddComment(new Comment("Eve", "Amazing footage."));
            v2.AddComment(new Comment("Frank", "Where is the 5th place located?"));
            v2.AddComment(new Comment("Grace", "Adding these to my bucket list."));
            videos.Add(v2);

            // Video 3
            Video v3 = new Video("How to Bake the Perfect Cake", "ChefBaker", 1200);
            v3.AddComment(new Comment("Heidi", "My cake turned out delicious!"));
            v3.AddComment(new Comment("Ivan", "What temperature for the oven?"));
            v3.AddComment(new Comment("Judy", "Love your recipes."));
            videos.Add(v3);

            // Display Info
            foreach (Video video in videos)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
                }
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
