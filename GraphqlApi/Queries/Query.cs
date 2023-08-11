using Bogus;
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
    public List<Book> GetBooks()
    {
        var faker = new Faker<Book>()
            .RuleFor(b => b.Title, f => f.Lorem.Word())
            .RuleFor(b => b.PageCount, f => f.Random.Int(100, 500))
            .RuleFor(b => b.Description, f => f.Lorem.Sentence())
            .RuleFor(b => b.Author, f => new Author
            {
                Name = f.Name.FullName(),
                Age = f.Random.Int(30, 70),
                Email = f.Person.Email
            });

        var books = faker.Generate(100);
        return books;
    }
}
