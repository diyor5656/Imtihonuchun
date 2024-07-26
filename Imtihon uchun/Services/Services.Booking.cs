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
        public static string GetAPath()
        {
            string currientPath = Directory.GetCurrentDirectory();
            currientPath += @"\arizalar.json";
            return currientPath;
        }
        public void ClearCFile()
        {
            Console.Clear();
            File.WriteAllText(GetCPath(), string.Empty);
            Console.WriteLine("Arizalar Tozalandi! ");
        }
        public void SaveC(List<Booking> bookings)
        {
            string serialized = JsonSerializer.Serialize(bookings);
            File.WriteAllText(GetBookPath(), serialized);
        }
    }
}
