using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class CommandHndl
    {
        public static void ExecuteCommand(string command)
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = "-c \" " + command + " \"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                Console.WriteLine(proc.StandardOutput.ReadLine());
            }
        }


        public static void ExecuteBashFile(string file_path)
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = " " + file_path;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                Console.WriteLine(proc.StandardOutput.ReadLine());
            }
        }


        public static void UserAcountFileMaker(string path, string username, string content)
        {
            using (TextWriter tw = new StreamWriter(path + username, true))
            {
                tw.WriteLine(content);
            }
        }


        public static void ConfigFileWriter(string file_path, string command_text)
        {
            // Write Config
            string path = file_path;

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(command_text);
                }
            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(command_text);
                }
            }
        }


        public static void users_list_reader(string path)
        {
            AcMng.ListFileInDir(path);
        }


        public static void ConfigDelete(string file_path)
        {
            // Write Config
            string path = file_path;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}