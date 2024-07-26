using Imtihon_uchun.Services;
using Classes;

public static class Program
{
    static void Main(string[] args)
    {
        var CentrServices = new Services();
        bool exit = false;
        int index = 0;

        List<string> buyruq1 = new List<string>
        {
            "                             Admin                                    ",
            "                            Kitobxon                                   "
        };
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("                       Online Kutubxona             ");
            Console.WriteLine("                    Siz Kitobxon yoki Admin?");
            for (int i = 0; i < buyruq1.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(buyruq1[i]);
                Console.ResetColor();
            }
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.DownArrow)
            {
                index = (index + 1) % buyruq1.Count;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                index = (index - 1 + buyruq1.Count) % buyruq1.Count;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                switch (index)
                {
                    case 0:
                        AdminMenu(CentrServices);
                        break;
                    case 1:
                        UserMenu(CentrServices);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
    static void AdminMenu(Services CentrServices)
    {
        bool exit = false;
        int index = 0;
        List<string> buyruq = new List<string>()
        {
            "                 Malumotlar               ",
            "               Kategoriyalar              ",
            "                  Kitoblar                ",
            "                Buyurtmalar                ",
            " Kitoblarni Kategoriyalar buyicha saralash ",
            "                   Orqaga                  "
        };
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("                   Admin                ");
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
                    case 0:
                        Services.AboutMenu(CentrServices);
                        break;
                    //case 1:
                    //    BooksMenu(CentrServices);
                    //    break;
                    //case 2:
                    //    CategoryMenu(CentrServices);
                    //    break;
                    //case 3:
                    //    BookingMenufa(CentrServices);
                    //case 4:
                    //    AttachBC(CentrServices);
                    //    break;
                    case 5:
                        exit = true;
                        break;
                }
                Console.ReadKey();
            }

        }

    }
    static void UserMenu(Services CentrServices)
    {
        bool exit = false;
        int index = 0;
        List<string> buyruq = new List<string>()
        {
            "                Malumotlar               ",
            "               Kategoriyalar             ",
            "               Buyurtmalarim             ",
            "                  Orqaga                 "
        };
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("                 Kitobxon                ");
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
                    //    AboutMenufu(CentrServices);
                    //    break;
                    //case 1:
                    //    CategoryMenufu(CentrServices);
                    //    break;
                    //case 2:
                    //    BookingMenu(CentrServices);
                    //    break;
                    case 3:
                        exit=true;
                        break;   
                   
                }
                Console.ReadKey();
            }

        }

    }

}

