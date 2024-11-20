internal class Logo
{
    public void MostrarBanner()
    {
        var bannerLines = new string[]
        {
            "                                        ",
            "                                        ",
            "                                        ",
            "                                        ",
            "                                        ",
            "                                        ",
            "▒█▀▀█ █░░█ ▀▀█▀▀ █▀▀ ▒█▀▀█ █▀▀█ █▀▀▄ █░█",
            "▒█▀▀▄ █▄▄█ ░░█░░ █▀▀ ▒█▀▀▄ █▄▄█ █░░█ █▀▄",
            "▒█▄▄█ ▄▄▄█ ░░▀░░ ▀▀▀ ▒█▄▄█ ▀░░▀ ▀░░▀ ▀░▀",
            "                                        ",
            "                                        ",
            "                                        "
        };

        var colors = new ConsoleColor[]
        {
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.DarkGreen,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.DarkYellow,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White,
            Console.ForegroundColor = ConsoleColor.White
        };

        Console.CursorVisible = false;
        for (int offset = 0; offset <= 6; offset++)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.ForegroundColor = colors[i + offset];
                Console.WriteLine(bannerLines[i + offset]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(100);
        }
        Console.SetCursorPosition(0, 4);
        Console.CursorVisible = true;
    }
}