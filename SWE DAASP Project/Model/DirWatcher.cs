using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SWE_DAASP_Project.Model
{
    class DirWatcher
    {
        

        public static void Run()
        {
            string path = "C:/Users/Yoshuam Alicea/Desktop/TestDir";      
            FileSystemWatcher watcher = new FileSystemWatcher(path);

            //watcher.Path = path;
            watcher.Filter = "*.*";
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.CreationTime | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
        }

        private static void OnRenamed(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }        
    }
}
