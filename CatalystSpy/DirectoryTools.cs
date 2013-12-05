using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CatalystSpy
{
    class DirectoryTools
    {
        public static long getSize(string path)
        {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            long directorySize = 0;
            foreach (string name in files)
            {
                FileInfo info = new FileInfo(name);
                directorySize += info.Length;
            }
            return directorySize;
        }

        public static void deleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            else
                throw new DirectoryNotFoundException();
        }
    }
}