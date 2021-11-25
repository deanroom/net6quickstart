using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace App.Terminal2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mutext = new Mutex(true, "GolbalMutext", out var createNew);
            var process = new Process
            {
                StartInfo =
                {
                    UseShellExecute = true,
                    FileName = "App.Terminal.exe",
                    WorkingDirectory =
                        @"E:\src\github.com\deanroom\dreamarchitecture\src\App\App.Terminal\bin\Debug\net5.0\",
                    WindowStyle = ProcessWindowStyle.Normal
                },
            };
            process.Start();
            if (createNew)
                mutext.WaitOne();
            Console.WriteLine("Press any key to close Terminal");
            Console.ReadKey();
            process.Kill();

        }
    }
}