using FirstMVCApp.Models;

namespace FirstMVCApp.Data
{
    public static class StaticDB
    {
        public static List<Book> Books { get; set; }
        static StaticDB()
        {
            Books = new List<Book>
            {
                new Book() { Id = 1, Title = "Lord of the RIngs" },
                new Book() { Id = 2, Title = "Harry Potter" },
                new Book() { Id = 3, Title = "1984" },
                new Book() { Id = 4, Title = "The Martian" }
            };
        }
    }
}
