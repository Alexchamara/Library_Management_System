class Menu
{
    public static void mainMenu()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine(String.Format("{0, -50}", "  Library Management System"));
        for (int i = 0; i < 50; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
    }
}