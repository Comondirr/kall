using System;
using System.Diagnostics;

class ChildProcess
{
    private Process _process;

    public ChildProcess()
    {
        _process = new Process();
        _process.StartInfo.FileName = "childProcess.exe"; // Путь к дочернему исполняемому файлу
        _process.EnableRaisingEvents = true;
    }

    public void RunChildProcess()
    {
        try
        {
            _process.Start();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при запуске дочернего процесса: " + ex.Message);
        }
    }

    public void WaitForChildProcess()
    {
        _process.WaitForExit();
    }

    public int ExitCode
    {
        get { return _process.ExitCode; }
    }
}
