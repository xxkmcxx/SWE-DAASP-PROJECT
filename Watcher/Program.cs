using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Watcher
{
    class Program
    {
       static int KEY;
       static string new_path;
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            do
            {

                string path = @"C:\Users\Yoshuam Alicea\Desktop\TestDir";
                FileSystemWatcher watcher = new FileSystemWatcher(path);

                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Filter = "*.*";

                watcher.Created += new FileSystemEventHandler(OnCreated);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);
                watcher.Deleted += new FileSystemEventHandler(OnDelete);

                watcher.EnableRaisingEvents = true;

               if(KEY == 1)
               {
                    
                    KEY = 0;
               }
                        
                    

                Console.WriteLine("Press q to quit program");
               
            } while (Console.Read() != 'q');
        }

        private static void OnDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.Name + " Deleted");
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File Renamed From " + e.OldName + " to " + e.Name);
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Created: " + e.FullPath);
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbooks books = excelApp.Workbooks;
            Excel.Workbook sheet = books.Open(e.FullPath);            
        }
       
    }
}
