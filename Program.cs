using System;
using System.Diagnostics;

namespace _28._06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "notepad.exe";
                process.StartInfo.Arguments = "";

                process.Start();

                process.WaitForExit();

                int exitCode = process.ExitCode;
                Console.WriteLine($"Exit code: {exitCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
