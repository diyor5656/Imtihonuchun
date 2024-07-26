namespace Imtihon_uchun.Services
{
    public partial class Services
    {
        List<string> Books = new List<string>();
        List<string> Booking = new List<string>();
        List<string> Category = new List<string>();
        List<string> About = new List<string>();
        public static void AboutMenu(Services CentrServices)
        {
            bool exit = false;
            int index = 0;
            List<string> buyruq = new List<string>()
        {
            "                 Malumot qushish               ",
            "               Malumotni tahrirlash            ",
            "                Malumotni O'chirish            ",
            "                    Malumotlar                 ",
            "                      Orqaga                   "
        };
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("                      Admin                ");
                for (int i = 0; i < buyruq.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(buyruq[i]);
                    Console.ResetColor();
                }
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    index = (index + 1) % buyruq.Count;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    index = (index - 1 + buyruq.Count) % buyruq.Count;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (index)
                    {
                        //case 0:
                        //    Services.AddAbout(CentrServices);
                        //    break;
                        //case 1:
                        //    Services.UpdateAbout(CentrServices);
                        //    break;
                        //case 2:
                        //    Services.DeleteAbout(CentrServices);
                        //    break;
                        //case 3:
                        //    Services.GetAbout(CentrServices);
                        //    break;
                        //case 4:
                        //    exit = true;
                        //    break;
                    }
                    Console.ReadKey();
                }

            }

        }
        public static void BooksMenu(Services CentrServices)
        {
            bool exit = false;
            int index = 0;
            List<string> buyruq = new List<string>()
        {
            "                 Kitob qushish                 ",
            "             Kitob Nomini tahrirlash            ",
            "               Kitobni O'chirish               ",
            "                    Kitoblar                   ",
            "                     Orqaga                   "
        };
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("                      Admin                ");
                for (int i = 0; i < buyruq.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(buyruq[i]);
                    Console.ResetColor();
                }
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    index = (index + 1) % buyruq.Count;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    index = (index - 1 + buyruq.Count) % buyruq.Count;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (index)
                    {
                        //case 0:
                        //    Services.AddBooks(CentrServices);
                        //    break;
                        //case 1:
                        //    Services.UpdateBooks(CentrServices);
                        //    break;
                        //case 2:
                        //    Services.DeleteBooks(CentrServices);
                        //    break;
                        //case 3:
                        //    Services.GetBooks(CentrServices);
                        //    break;
                        //case 4:
                        //    exit = true;
                        //    break;
                    }
                    Console.ReadKey();
                }

            }

        }
    }
}
