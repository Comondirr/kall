using System;

class Program
{
    static void Main(string[] args)
    {
        ParentProcess parentProcess = new ParentProcess();
        parentProcess.Run();

        // Дожидаемся нажатия любой клавиши перед закрытием окна консоли
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
