using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Imtihon_uchun.Services
{
    
    public partial class Services
    {
        public static string GetBookPath()
        {
            string currientPath=Directory.GetCurrentDirectory();
            currientPath += @"\kitoblar.json";
            return currientPath;
        }
        public void ClearBFile()
        {
            Console.Clear();
            File.WriteAllText(GetBookPath(),string.Empty);
            Console.WriteLine("Malumotlar Tozalandi! ");
        }
        public void SaveBooks(List<Books> books)
        {
            string serialized =JsonSerializer.Serialize(books);
            File.WriteAllText(GetBookPath(),serialized);
        }
        public void AddBooks()
        {
            Console.Clear();
            List<Books> books = new List<Books>();
            Console.Write("Kitob Nomini kiriting: ");
            string bookname = Console.ReadLine();
            int newId = books.Count > 0 ? books.Max(t => t.Id) + 1 : 1;
            Books book = new Books()
            {
                Id = newId,
                Name = bookname,

            };
            books.Add(book);
            SaveBooks(books);
            Console.WriteLine("Kitob Muvaffaqiyatli qo'Shildi! ");

        }
        public void DeleteBooks()
        {
            Console.Clear();    
            List<Books> books=new List<Books>();
            Console.Write("O'chirish uchun Kitob Id kiriting: ");
            int bookId;
            while (!int.TryParse(Console.ReadLine(), out bookId))
            {
                Console.Write("Iltimos Id ni kiriting : ");
            }

            Books bookToDelete = books.FirstOrDefault(t => t.Id == bookId);
            if (bookToDelete == null)
            {
                Console.WriteLine("Kitob topilmadi");
                return;
            }

            books.Remove(bookToDelete);
            SaveBooks(books);

            Console.WriteLine("Kitoblar o'chirib tashlandi.");
        }
        public List<Books> GetBooks()
        {
            Console.Clear();

            if (!File.Exists(GetBookPath()))
            {
                Console.WriteLine("Hozircha Kitoblar yo'q");
            }
            if (!File.Exists(GetBookPath()))
            {
                return new List<Books>();
            }

            string jsonFromFile = File.ReadAllText(GetBookPath());
            var books = string.IsNullOrEmpty(jsonFromFile) ? new List<Books>() : JsonSerializer.Deserialize<List<Books>>(jsonFromFile);

            Console.WriteLine("Mentorlar Ro'yxati:");
            foreach (var book in books)
            {
                Console.WriteLine($"Id: {book.Id}, Nomi: {book.Name}");
            }

            return books;
        }
        public void UpdateBooks()
        {
            Console.Clear();
            List<Books> books = new List<Books>();
            Console.Write("Yangilash ucun Kitob Id sini kiriting : ");
            int bookId;
            while (!int.TryParse(Console.ReadLine(), out bookId))
            {
                Console.Write("Iltimos Id kiriting: ");
            }

            Books bookToUpdate = books.FirstOrDefault(t => t.Id == bookId);
            if (bookToUpdate == null)
            {
                Console.WriteLine("Kitob kiriting.");
                return;
            }

            Console.Write("Yangi Ism kiriting : ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                bookToUpdate.Name = newName;
            }
            SaveBooks(books);
            Console.WriteLine("Kitob muvaffaqiyqtli qo'shildi!");
        }
    }




    

}
