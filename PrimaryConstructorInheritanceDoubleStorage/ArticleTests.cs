using FluentAssertions;

namespace PrimaryConstructorInheritanceDoubleStorage;

public class Tests
{
    [Test]
    public void TitleValueIsTheSameInBaseAndDerivedClass()
    {
        var article = new PrintedArticle("Damir Arh", "What's new in C# 12", 10);
        article.Title = "New features in C# 12";

        article.ToString().Should().StartWith(article.Title);
    }
}