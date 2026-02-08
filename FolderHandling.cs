using System;
using System.IO;
using System.Threading;

namespace FolderXFiles
{
  class folderSettings
    {
        public static async Task FolderSelection(String folder)
        {
            // switch statements based on input 
            try
            {
                switch (folder)
                {
                    case "1":
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var desktopFiles = Directory.GetFiles(desktopPath);
                        int desktopCount = 0;
                        foreach (var file in desktopFiles)
                        {
                            desktopCount++;
                            Console.WriteLine($"{desktopCount}. {Path.GetFileName(file)}");
                        }
                        // list all files within the folder 
                        break;
                    case "2":
                        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        var documentsFiles = Directory.GetFiles(documentsPath);
                        int documentsCount = 0;
                        foreach (var document in documentsFiles)
                        {
                            documentsCount++;
                            Console.WriteLine($"{documentsCount}. {Path.GetFileName(document)}");
                        }
                        break;
                    case "3":
                        string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                        var downloadFiles = Directory.GetFiles(downloadsPath);
                        int downloadCount = 0;
                        foreach (var download in downloadFiles)
                        {
                            downloadCount++;
                            Console.WriteLine($"{downloadCount}. {Path.GetFileName(download)}");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
