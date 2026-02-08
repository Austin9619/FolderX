using System;
using System.IO;
using System.Reflection.Metadata;
using System.Threading;
using FolderXFiles;

namespace folderX
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("How many folders do you want to scan ?");
            string answer = Console.ReadLine();
            // make sure user string is not empty 
            while(string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("Your answer can not be blank\n");
                answer = Console.ReadLine();
            }
            if (answer == "1")
            {
                await Program.inputHandling("1");
            }
            else if (answer == "2")
            {
                await Program.inputHandling("2");
            }
            else if (answer == "3")
            {
                await Program.inputHandling("3");
            }
            else
            {
                Console.WriteLine("Input a valid selection");
            }


        }

        static async Task inputHandling(string input)
        {
            try
            {
                if (input == "1")
                {
                    Console.WriteLine("Input from the following options which folder you want to scan");
                    Console.WriteLine("1. Desktop folder\n" +
                        "2. Documents Folder\n" +
                        "3. Downloads Folder");
                    // user answer 
                    string folderSelection = Console.ReadLine();
                    // make sure selection is not blank 
                    while (string.IsNullOrEmpty(folderSelection))
                    {
                        Console.WriteLine("Your answer can not be blank");
                        folderSelection = Console.ReadLine();
                    }
                    switch (folderSelection)
                    {
                        case "1":
                            await folderSettings.FolderSelection("1");
                            break;
                        case "2":
                            await folderSettings.FolderSelection("2");
                            break;
                        case "3":
                            await folderSettings.FolderSelection("3");
                            break;
                    }
                }
                if (input == "2")
                {
                    Console.WriteLine("Enter which 2 folders you wish to scan from the following options");
                    Console.WriteLine("1. Desktop folder\n" +
                        "2. Documents Folder\n" +
                        "3. Downloads Folder");
                    string firstFolder = Console.ReadLine();
                    Console.WriteLine("Enter the 2nd folder you wish to search");
                    string secondFolder = Console.ReadLine();
                    // making sure neither input is empty 
                    while (string.IsNullOrEmpty(firstFolder) || string.IsNullOrEmpty(secondFolder))
                    {
                        if (string.IsNullOrEmpty(firstFolder))
                        {
                            Console.WriteLine("First folder can not be left empty");
                            firstFolder = Console.ReadLine();
                        }
                        if (string.IsNullOrEmpty(secondFolder))
                        {
                            Console.WriteLine("Second folder can not be left empty");
                            secondFolder = Console.ReadLine();
                        }
                    }
                    // handling folder input 
                    if (firstFolder == "1" && secondFolder == "2")
                    {
                        await Task.WhenAll(folderSettings.FolderSelection("1"), folderSettings.FolderSelection("2"));
                    }
                    if (firstFolder == "1" && secondFolder == "3")
                    {
                        await Task.WhenAll(folderSettings.FolderSelection("1"), folderSettings.FolderSelection("3"));
                    }
                    if (firstFolder == "2" && secondFolder == "3")
                    {
                        await Task.WhenAll(folderSettings.FolderSelection("2"), folderSettings.FolderSelection("3"));
                    }
                }
                if (input == "3")
                {
                    Console.WriteLine("Scanning all 3 folders (Desktop, documents and downloads folder)....please wait");
                    await Task.WhenAll(folderSettings.FolderSelection("1"), folderSettings.FolderSelection("2"), folderSettings.FolderSelection("3"));
                }
                else
                {
                    Console.WriteLine("Select a valid option");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}