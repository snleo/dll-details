using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_fileinfo
{
    public class DLLHelper
    {
        public static string GetVersion(string filePath)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(filePath);
            return fvi.FileVersion;
        }

        public static string GetDescritpion(string filePath)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(filePath);
            return fvi.FileDescription;
        }

        public static string[] GetFullNames(string filePath)
        {
            List<string> rtn = new List<string>();
            try
            {
                var dll = Assembly.LoadFile(filePath);
                foreach (Type t in dll.GetExportedTypes())
                {
                    rtn.Add(t.Assembly.FullName);
                }
            }
            catch(Exception ex)
            {
                rtn.Add("Cannot obtain assembly - " + ex.ToString());
            }
            return rtn.ToArray();
        }
    }
}
