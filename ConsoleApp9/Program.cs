class Program
{
    static void Main()
    {
        string[,] Questions = new string[,]
        {
            {"Azerbaycanin Paytaxti Haradir ?","fA)Quba","fB)Gence","tC)Baki","nNovbeti Suala Kecmek" },
            {"Ikinci Dunya Muharibesi Hacan Bashlayib ?","fA)1941","tB)1939","fC)1940","nNovbeti Suala Kecmek" },
            {"Hansi Proqramlasdirma dilidir","tA)C/C++","fB)Alman","fC)Ingilis","nNovbeti Suala Kecmek" },
            {"Everestin Hundurluyu Ne Qederdir" ,"tA)8848" ,"fB)8000" ,"fC)8499","nNovbeti Suala Kecmek" }
        };
        bool start = true;
        int select = 1;
        int score = 0;
        ConsoleKeyInfo keyInfo;
        for (int i = 0; i < Questions.Length; i++)
        {
            while (start)
            {
                if (i < Questions.Length)
                {
                    Console.Clear();
                    Console.WriteLine($"{i+1}){Questions[i, 0]}");
                    for (int j = 1; j < 5; j++)
                    {
                        if (j == select)
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        string Anwes = Questions[i, j].Substring(1);

                        Console.WriteLine(Anwes);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    keyInfo = Console.ReadKey();
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (select != 1)
                                select--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (select + 1 < 5)
                                select++;
                            break;
                        case ConsoleKey.Enter:
                            for (int j = 1; j < 5; j++)
                            {
                                if (j == select && Questions[i, j].Substring(0, 1) == "t")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    score += 5;
                                    break;
                                }
                                else if (j == select && Questions[i, j].Substring(0, 1) == "n")
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    break;
                                }
                                else if (j == select)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    score -= 5;
                                    break;
                                }
                            }
                            i++;
                            Console.Clear();
                            break;
                    }

                    if(keyInfo.Key == ConsoleKey.Enter)
                    {
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Davam Etmek Ucun Enter Cixmaq Ucun Tab Duymesini Basin");
                            keyInfo = Console.ReadKey();
                            if(keyInfo.Key == ConsoleKey.Enter){
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            }
                            else if(keyInfo.Key == ConsoleKey.Tab)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                i = 4;
                                break;
                            }
                        }
                        Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (i == 4)
                {
                    start = false;
                    Console.WriteLine($"Sizin Topladiqiniz Netice {score}");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                }
            }
        }
    }
}