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
                process.StartInfo.RedirectStandardOutput = false;
                process.StartInfo.RedirectStandardError = false;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = false;

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
