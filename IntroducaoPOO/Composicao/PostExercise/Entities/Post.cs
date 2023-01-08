using System.Text;
using PostExercise.Entities;

namespace PostExercise.Entities
{
  class Post
  {
    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; }  = new List<Comment>();

    public Post()
    {
    }

    public Post(DateTime moment, string title, string content, int likes)
    {
      Moment = moment;
      Title = title;
      Content = content;
      Likes = likes;
    }

    public void AddComment(Comment comment){
      Comments.Add(comment);
    }

    public void AddRemove(Comment comment)
    {
      Comments.Remove(comment);
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(Title);
      sb.AppendLine($"{Likes} Likes - {Moment}");
      sb.AppendLine(Content);
      sb.AppendLine("Comments:");
      foreach (Comment comment in Comments)
      {
        sb.AppendLine(comment.Text);
      }
      return sb.ToString();
    }
  }
}