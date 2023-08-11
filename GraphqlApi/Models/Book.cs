namespace GraphqlApi.Models;

public class Book
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int PageCount { get; set; }

    public Author Author { get; set; }
}
