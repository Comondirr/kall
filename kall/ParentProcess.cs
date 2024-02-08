using System;
using System.Diagnostics;

class ParentProcess
{
    public void Run()
    {
        // Получаем текущую директорию приложения
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Составляем полный путь к файлу childProcess.exe
        string childProcessPath = System.IO.Path.Combine(currentDirectory, "childProcess.exe");

        // Проверяем, существует ли файл childProcess.exe
        if (System.IO.File.Exists(childProcessPath))
        {
            // Создаем экземпляр процесса и устанавливаем параметры
            Process childProcess = new Process();
            childProcess.StartInfo.FileName = childProcessPath;

            // Запускаем дочерний процесс
            try
            {
                childProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при запуске дочернего процесса: " + ex.Message);
                return;
            }

            // Ожидаем завершения дочернего процесса
            childProcess.WaitForExit();

            // Выводим код завершения дочернего процесса
            Console.WriteLine("Дочерний процесс завершился с кодом: " + childProcess.ExitCode);
        }
        else
        {
            Console.WriteLine("Файл childProcess.exe не найден в текущей директории.");
        }
    }
}
