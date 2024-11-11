using System;
using System.Diagnostics;
using System.IO;

namespace ConvApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            string t = Console.ReadLine();
            decimal a = Convert.ToDecimal(Console.ReadLine());

            decimal c = Convert(f, t, a);
            Save(f, t, a, c);
            Console.WriteLine(c);
        }

        static decimal Convert(string f, string t, decimal a)
        {
            string ps = $"convert.py {f} {t} {a}";
            ProcessStartInfo psi = new ProcessStartInfo("python", ps)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process p = Process.Start(psi))
            using (StreamReader r = p.StandardOutput)
            {
                string res = r.ReadToEnd();
                return Convert.ToDecimal(res);
            }
        }

        static void Save(string f, string t, decimal a, decimal c)
        {
            string file = "history.txt";
            string line = $"{f} {a} -> {t} {c}\n";
            File.AppendAllText(file, line);
        }
    }
}
