using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameFileTool
{
    public class Algorithm
    {
        public static string GetFileNameFromPath(string path)
        {
            int lastindex = path.LastIndexOf('\\');
            string result = path.Substring(lastindex+1);
            return result;
        }
        public static string GetFileNameWithoutExtensionFromPath(string path)
        {
            int lastindex = path.LastIndexOf('\\');
            string result = path.Substring(lastindex + 1);
            lastindex = result.LastIndexOf('.');
            result = result.Substring(0, lastindex);
            return result;
        }
        public static List<string> GetPathsOfFilesFromAFolder(string selectedpath, FileInfo[] files)
        {
            List<string> result = new List<string>();
            int flag = 0;
            foreach (FileInfo fi in files)
            {
                result.Add(selectedpath + "\\" + fi.Name);
                flag = flag + 1;
            }
            return result;
        }
        public static List<string> GetAListOfNamesOfFilesFromAFolder(string selectedpath, FileInfo[] files)
        {
            List<string> result = new List<string>();
            int flag = 0;
            foreach (FileInfo fi in files)
            {
                result.Add(fi.Name);
                flag = flag + 1;
            }
            return result;
        }
        public static string GetFolderPathFromAFilePath(string FilePath)
        {
            int index = FilePath.LastIndexOf('\\');
            string result = FilePath.Substring(0, index);
            return result;
        }
        public static string GetFolderNameFromPath(string FilePath)
        {
            int index = FilePath.LastIndexOf('\\');
            string result = FilePath.Substring(0, index);
            index = result.LastIndexOf('\\');
            result = result.Substring(index+1);
            return result;
        }
        public static string GetExtension(string FilePath)
        {
            int index = FilePath.LastIndexOf('.');
            if (index > -1)
            {
                string result = FilePath.Substring(index);
                return result;
            }
            else
            {
                return "";
            }
        }
        public static string GetNewNumberString(int number, int numberofcharacter)
        {
            string result = number.ToString(); 
            while(result.Length < numberofcharacter)
            {
                result = "0" + result;
            }
            return result;
        }
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcefghiklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
