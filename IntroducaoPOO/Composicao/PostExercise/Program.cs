using System;
using PostExercise.Entities;

namespace PostExercise {
  internal class Program
  {
    static void Main(string[] args)
    {
      DateTime moment1 = DateTime.Parse("21/06/2018 13:05:44");
      string title1 = "Traveling to New Zealand";
      string content1 = "I'm going to visit this wonderful country!";
      int likes1 = 12;

      Comment post1comment1 = new Comment("Have a nice trip");
      Comment post1comment2 = new Comment("Wow that's awesome!");

      Post blogPost1 = new Post(moment1, title1, content1, likes1);
      blogPost1.Comments.Add(post1comment1);
      blogPost1.Comments.Add(post1comment2);


      DateTime moment2 = DateTime.Parse("28/07/2018 23:14:19");
      string title2 = "Good night guys";
      string content2 = "See you tomorrow";
      int likes2 = 5;

      Comment post2comment1 = new Comment("Good night");
      Comment post2comment2 = new Comment("May the Force be with you");

      Post blogPost2 = new Post(moment2, title2, content2, likes2);

      blogPost2.AddComment(post2comment1);
      blogPost2.AddComment(post2comment2);

      System.Console.WriteLine(blogPost1);
      System.Console.WriteLine(blogPost2);

      
    }
  }
}
