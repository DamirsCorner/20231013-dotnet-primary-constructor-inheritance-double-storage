namespace PrimaryConstructorInheritanceDoubleStorage;

public class Article(string author, string title)
{
    public string Author => author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public override string ToString()
    {
        return $"{author}: {title}";
    }
}