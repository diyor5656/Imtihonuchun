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
        public static string GetAPath()
        {
            string currientPath = Directory.GetCurrentDirectory();
            currientPath += @"\arizalar.json";
            return currientPath;
        }
        public void ClearAFile()
        {
            Console.Clear();
            File.WriteAllText(GetAPath(), string.Empty);
            Console.WriteLine("Arizalar Tozalandi! ");
        }
        public void SaveB(List<Booking> bookings)
        {
            string serialized = JsonSerializer.Serialize(bookings);
            File.WriteAllText(GetBookPath(), serialized);
        }
        public void AddBooking()
        {
            Console.Clear();
            List<Booking> bookings = new List<Booking>();
            Console.Write("Kitob Nomini kiriting: ");
            string bookname = Console.ReadLine();
            int newId = bookings.Count > 0 ? bookings.Max(t => t.Id) + 1 : 1;
            Booking boking = new Booking()
            {
                Id = newId,
                Name = bookname,

            };
            bookings.Add(boking);
            SaveB(bookings);
            Console.WriteLine("Ariza Muvaffaqiyatli qo'Shildi! ");
        }

    }
}
