namespace _04.Social_Media_Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var socitalMediaPosts = new Dictionary<string, Dictionary<string, List<string>>>();
           

            while (inputLine != "drop the media")
            {
                var actions = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var commnad = actions[0];

                switch (commnad)
                {
                    case "post":
                        if (!socitalMediaPosts.ContainsKey(actions[1]))
                        {
                            socitalMediaPosts[actions[1]] = new Dictionary<string, List<string>>();
                        }
                        break;
                    case "like":

                        if (!socitalMediaPosts[actions[1]].ContainsKey("Like"))
                        {
                            socitalMediaPosts[actions[1]]["Like"] = new List<string>();
                        }
                        socitalMediaPosts[actions[1]]["Like"].Add(commnad);

                        break;
                    case "dislike":


                        if (!socitalMediaPosts[actions[1]].ContainsKey("Dislike"))
                        {
                            socitalMediaPosts[actions[1]]["Dislike"] = new List<string>();
                        }
                        socitalMediaPosts[actions[1]]["Dislike"].Add(commnad);

                        break;
                    case "comment":

                        var userComment = actions[2];

                        if (!socitalMediaPosts[actions[1]].ContainsKey(userComment))
                        {
                            socitalMediaPosts[actions[1]][userComment] = new List<string>();
                        }

                        var commentToAdd = string.Empty;
                        for (int i = 3; i < actions.Count; i++)
                        {
                            commentToAdd += (actions[i] + " ");
                        }
                        socitalMediaPosts[actions[1]][userComment].Add(commentToAdd);
                        break;
                }

                inputLine = Console.ReadLine();
            }


            foreach (var post in socitalMediaPosts)
            {

                var like = 0;
                var dislike = 0;
                var postName = post.Key;
                var postedString = post.Value;

                foreach (var item in postedString)
                {

                    if (item.Key == "Like")
                    {
                        like = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislike = item.Value.Count;
                    }
                }
                
                Console.WriteLine($"Post: {postName} | Likes: {like} | Dislikes: {dislike}");
                Console.WriteLine("Comments:");

                var noComments = true;

                foreach (var comment in postedString)
                {
                    if (comment.Key != "Like" && comment.Key != "Dislike")
                    {
                        noComments = false;
                        foreach (var com in comment.Value)
                        {

                            Console.WriteLine($"*  {comment.Key}: {com}");
                        }
                    }
                }

                if (noComments)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
