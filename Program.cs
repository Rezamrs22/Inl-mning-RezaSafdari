





using Bibliotek.Models;
using Bibliotekssystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Extensibility;

class Program
{
    static void Main(string[] args)
    {
        using ( var context = new AppDBContext())
        {
            Console.WriteLine("Hello Wellcome to REZA SAFDARI linbrary");

            string Name = "Alireza";
            string Title = "Brott och straff";

            var existdata = context.Authors.FirstOrDefault(a => a.Name == Name);
            var existdata1 = context.Books.FirstOrDefault(b => b.Title == Title);

            if (existdata != null)
            {
                System.Console.WriteLine("Ther is alredy author in database");
                
            }
            else if(existdata1 != null)
            {
                System.Console.WriteLine("Ther is alredy book in database");
            }
            else
            {
                var a1 = new Author{ Name = "Fjodor Dostojevskij"};
                context.Authors.Add(a1);


                var b1 = new Book {Title = "Brott och straff"};
                context.Books.Add(b1);
                context.SaveChanges();
           

                var ab1 = new AuthorBook
                {
                    BookID = b1.BookID,
                    AuthorID = a1.AuthorID
                };
                context.Set<AuthorBook>().Add(ab1);
                context.SaveChanges();
                System.Console.WriteLine("Book is Added in Database");

            }
            
            


            
        };
    
    }
}