using Mini_Library_System.Models;

namespace Mini_Library_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- KİTABXANA SİSTEMİ ---\n");
            Book book1 = new Book
            {
                Title = "Cinayet ve Ceza",
                Author = "F. Dostoevski",
                Code = new BookCode { Section = "A", Number = 15 },
                CreatedAt = DateTime.Now.AddDays(-2)
            };

            Book book2 = new Book
            {
                Title = "Sefiller",
                Author = "V. Huqo",
                Code = new BookCode { Section = "B", Number = 42 },
                CreatedAt = DateTime.Now.AddDays(-10)
            };
            Book book3 = new Book
            {
                Title = "Eli ve Nino",
                Author = "Qurban Seid",
                Code = new BookCode { Section = "C", Number = 27 },
                CreatedAt = DateTime.Now.AddDays(-5)
            };

            LibraryBook libBook1 = new LibraryBook(book1);
            LibraryBook libBook2 = new LibraryBook(book2);
            LibraryBook libBook3 = new LibraryBook(book3);

            Console.WriteLine($"'{book1.Title}' yeni kitabdır? : {book1.CreatedAt.IsNew()}");
            Console.WriteLine($"'{book2.Title}' yeni kitabdır? : {book2.CreatedAt.IsNew()}");
            Console.WriteLine($"'{book3.Title}' yeni kitabdır? : {book3.CreatedAt.IsNew()}\n");

            Console.WriteLine("--- EMELİYYATLAR ---");
            Console.WriteLine(book1.Code.ToString());
            libBook1.Borrow();
            libBook1.Borrow();
            libBook1.Return();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine((book2.Code.ToString()));
            libBook2.Borrow();
            libBook2.Return();
            libBook2.Return();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine((book3.Code.ToString()));
            libBook3.Borrow();
            libBook3.Return();
            Console.WriteLine("-----------------------------------------------------");

        }
    } 
}

