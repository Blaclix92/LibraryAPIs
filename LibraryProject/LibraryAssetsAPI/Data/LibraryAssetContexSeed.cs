using LibraryAssetsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssetsAPI.Data
{
    public class LibraryAssetContexSeed
    {
        public static async Task SeedAsync(LibraryAssetContex context)
        {
            if (!context.Status.Any())
            {
                context.Status.AddRange(GetPreconfiguredStatus());
                await context.SaveChangesAsync();
            }

            if (!context.Video.Any())
            {
                context.Video.AddRange(GetPreconfiguredVideo());
                await context.SaveChangesAsync();
            }
 
            if (!context.Book.Any())
            {
                context.Book.AddRange(GetPreconfiguredBook());
                await context.SaveChangesAsync();
            }

        }

        static IEnumerable<Video> GetPreconfiguredVideo()
        {
            return new List<Video>()
            {
                new Video() { Id= 1, Title = "Addidas",Year = 2017,  Cost = 80, ImageUrl= "Unkown", NumberOfCopies = 10,  StatusId = 1, Director="Chow"},
                new Video() { Id= 2, Title = "Nike",Year = 2017,  Cost = 10, ImageUrl= "Unkown", NumberOfCopies = 5,   StatusId = 2,  Director="Mohan"},
                new Video() { Id= 3, Title = "Puma",Year = 2017,  Cost = 40, ImageUrl= "Unkown", NumberOfCopies = 10,  StatusId = 3, Director="Martinus"}

            };
        }

        static IEnumerable<Status> GetPreconfiguredStatus()
        {
            return new List<Status>()
            {
                new Status() { Id =1, Name= "Healthy", Description="Just Do It!"},
                new Status() { Id =2, Name= "FastFood", Description="Wife!"},
                new Status() { Id =3, Name= "Restaurant", Description="Money!"}
            };
        }
        static IEnumerable<Book> GetPreconfiguredBook()
        {
            return new List<Book>()
            {
                new Book() { Id = 1, Title = "WonderWoman", Year = 2010, Cost = 80, ImageUrl = "Unkown", NumberOfCopies = 10, StatusId = 1,  Author="Stanley", ISBN="123", DeweyIndex="hello"},
                new Book() { Id = 2, Title = "SuperMan", Year = 2010, Cost = 80, ImageUrl = "Unkown", NumberOfCopies = 10, StatusId = 2, Author="Stanley", ISBN="1234", DeweyIndex="helloMe"},
                new Book() { Id = 3, Title = "BatMan", Year = 2011, Cost = 80, ImageUrl = "Unkown", NumberOfCopies = 10, StatusId = 3, Author="Stanley", ISBN="1235", DeweyIndex="helloYou"},
                new Book() { Id = 4, Title = "Joker", Year = 2012, Cost = 80, ImageUrl = "Unkown", NumberOfCopies = 10, StatusId = 2, Author="Stanley", ISBN="1236", DeweyIndex="helloUs"},
                new Book() { Id = 5, Title = "GreenLantern", Year = 2013, Cost = 80, ImageUrl = "Unkown", NumberOfCopies = 10, StatusId = 2, Author="Stanley", ISBN="1237", DeweyIndex="helloWorld"},

            };
        }
    }
}
