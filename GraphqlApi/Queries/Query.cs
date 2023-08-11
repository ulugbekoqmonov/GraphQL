using GraphqlApi.Models;

namespace GraphqlApi.Queries;

public class Query
{
    public Book GetBook() =>
        new Book()
        {
            Title = "C# in depth.",
            PageCount = 111,            
            Author = new Author
            {
                Name = "Jon Skeet",
                Age = 41,
                Email = "jonskeet@gamil.com"
            }
        };
}
