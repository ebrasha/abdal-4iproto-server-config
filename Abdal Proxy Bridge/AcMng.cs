using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class AcMng
    {
        public static void ListFileInDir(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            var counter = 0;
            if (fileEntries.Length > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("------------ All users list ------------");
                foreach (string fileName in fileEntries)
                {
                    counter++;

                    Console.WriteLine("{0}. {1}  - Created on  {2}", counter, Path.GetFileName(fileName),
                        File.GetCreationTime(fileName).ToString());
                }
            }
            else
            {
                MessageManagements.ErrorMessage("There is no any user in database");
            }
        }

        public static void delete_file_user(string targetDirectory,string userName)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            bool userNameFind = false;

            if (fileEntries.Length > 0)
            {

                foreach (string fileName in fileEntries)
                {
                    if (Path.GetFileName(fileName) == userName)
                    {
                        File.Delete(fileName);
                        userNameFind = true;
                    }
                }

                if (userNameFind)
                {
                    MessageManagements.SuccessMessage(userName+" has been deleted");
                }
                else
                {
                    MessageManagements.ErrorMessage(userName + " not exists!");
                }
            }
            else
            {
                MessageManagements.ErrorMessage("There is no any user in database");
            }
        }

    }
}