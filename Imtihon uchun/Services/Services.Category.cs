using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Imtihon_uchun.Services
{
    public partial class Services
    {
        public static string GetCPath()
        {
            string currientPath=Directory.GetCurrentDirectory();
            currientPath += @"\category.json";
            return currientPath;
        }
        public void ClearCFile()
        {
            Console.Clear();
            File.WriteAllText(GetCPath(), string.Empty);
            Console.WriteLine("Categoriya Tozalandi! ");
        }
        public void SaveC(List<Category> categoriys)
        {
            string serialized = JsonSerializer.Serialize(categoriys);
            File.WriteAllText(GetBookPath(), serialized);
        }
        public void AddC()
        {
            Console.Clear() ;
            List<Category> categoriys = new List<Category>();   
            Console.Write("Categoriya Nomini kiriting: ");
            string cname = Console.ReadLine();
            int newId = categoriys.Count > 0 ? categoriys.Max(t => t.Id) + 1 : 1;
            Category c = new Category()
            {
                Id = newId,
                Name = cname,

            };
            categoriys.Add(c);
            SaveC(categoriys);
            Console.WriteLine("categoriya Muvaffaqiyatli qo'Shildi! ");
        }
        public void UpdateC()
        {
            Console.Clear() ;
            List<Category> categories = new List<Category>();
            Console.Write("Yangilash ucun Categoriya Id sini kiriting : ");
            int cId;
            while (!int.TryParse(Console.ReadLine(), out cId))
            {
                Console.Write("Iltimos Id kiriting: ");
            }

            Category cToUpdate = categories.FirstOrDefault(t => t.Id == cId);
            if (cToUpdate == null)
            {
                Console.WriteLine("Categoriyani kiriting.");
                return;
            }

            Console.Write("Yangi nom kiriting : ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                cToUpdate.Name = newName;
            }
            SaveC(categories);
            Console.WriteLine("Categoriya muvaffaqiyqtli qo'shildi!");
        }
        public void DeleteC()
        {
            Console.Clear() ;
            List <Category> categories = new List<Category>();
            Console.Write("O'chirish uchun Categoriya Id kiriting: ");
            int cId;
            while (!int.TryParse(Console.ReadLine(), out cId))
            {
                Console.Write("Iltimos Id ni kiriting : ");
            }

            Category cToDelete = categories.FirstOrDefault(t => t.Id == cId);
            if (cToDelete == null)
            {
                Console.WriteLine("Categoriya topilmadi");
                return;
            }

            categories.Remove(cToDelete);
            SaveC(categories);

            Console.WriteLine("Categoriya o'chirib tashlandi.");
        }
        public List<Category> GetC()
        {
            Console.Clear();

            if (!File.Exists(GetCPath()))
            {
                Console.WriteLine("Hozircha Categoriya yo'q");
            }
            if (!File.Exists(GetCPath()))
            {
                return new List<Category>();
            }

            string jsonFromFile = File.ReadAllText(GetBookPath());
            var categories = string.IsNullOrEmpty(jsonFromFile) ? new List<Category>() : JsonSerializer.Deserialize<List<Category>>(jsonFromFile);

            Console.WriteLine("Mentorlar Ro'yxati:");
            foreach (var category in categories)
            {
                Console.WriteLine($"Id: {category.Id}, Nomi: {category.Name}");
            }

            return categories;
        }
    }
}
