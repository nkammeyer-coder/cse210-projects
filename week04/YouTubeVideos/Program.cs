using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // list to hold videos.
        List<Video> videos = new List<Video>();

        // create video 1.
        Video video1 = new Video(
            "How to Smoke the Perfect Brisket",
            "Backyard BBQ Guide",
            742
        );
        video1.AddComment(
            new Comment ("John", "This made the cooking process so much easier to understand.")
        );
        video1.AddComment(
            new Comment ("Curtis", "I tried this method for cooking brisket and it turned out awesome!")
        );
        video1.AddComment(
            new Comment ("BonQuiQui", "What temperature do you recommend for the resting period on the pulled pork?")
        );
        videos.Add(video1);

        // create video 2.
        Video video2 = new Video(
            "Kia EV9 vs Rivian R1S",
            "3-Row EV comparison",
            1193
        );
        video2.AddComment(
            new Comment ("James", "This video made it easier to narrow down my EV options.")
        );
        video2.AddComment(
            new Comment ("Holly", "Thanks for showing the options between the EV9 and the R1S!")
        );
        video2.AddComment(
            new Comment ("Carlos", "Can you make another video showing the range between these two?")
        );
        videos.Add(video2);

        // create video 3.
        Video video3 = new Video(
            "Exploring Northern Arizona",
            "Southwest Adventures",
            623
        );
        video3.AddComment(
            new Comment ("Ashley", "The scenery was so pretty in Northern Arizona.")
        );
        video3.AddComment(
            new Comment ("David", "Are there easier trails for those that aren't so adventurous?")
        );
        video3.AddComment(
            new Comment ("Riley", "I've visited so many of your recommendations! When is the best time to visit Snowflake, Arizona?")
        );
        videos.Add(video3);

        // Show all the videos.
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"~ {comment.GetDisplayText()}");
            }
            Console.WriteLine();
        }
    }
}