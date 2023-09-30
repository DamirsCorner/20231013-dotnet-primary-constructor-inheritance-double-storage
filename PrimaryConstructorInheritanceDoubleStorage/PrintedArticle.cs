namespace PrimaryConstructorInheritanceDoubleStorage;

public class PrintedArticle(string author, string title, int noPages)
    : Article(author, title)
{
    public int NoPages => noPages;

    public override string ToString()
    {
        return $"{title} by {author} ({noPages} pages)";
    }
}