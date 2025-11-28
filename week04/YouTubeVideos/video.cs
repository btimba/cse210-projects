public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment>_comments = new List <Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }
}

    /*

}********class Video*******
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }

    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        if (comment != null)
        {
            comments.Add(comment);
        }
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        // return a copy to prevent external modification
        return new List<Comment>(comments);
    }
}
*/