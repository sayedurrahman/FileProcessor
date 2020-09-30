using FileProcessor.Service.Classes;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileProcessor.Service
{
    public class FileProcessorController
    {
        public string FolderPath { get; set; }
        public string TargetString { get; set; }
        public string ReplaceString { get; set; }
        public FileProcessorController(string folderPath, string targetText , string replaceText)
        {
            FolderPath = folderPath;
            TargetString = targetText;
            ReplaceString = replaceText;
        }

        public async Task UpdateTextInFiles()
        {
            if (Directory.Exists(FolderPath))
            {
                List<Task> tasks = new List<Task>();
                foreach (string fileName in Directory.GetFiles(FolderPath))
                {
                    tasks.Add(Task.Run(() => ReplaceTextInFile(fileName)));
                }

                await Task.WhenAll(tasks);
            }
        }

        public async Task ReplaceTextInFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            CompanyFile file = FileFactory.GetInstance(fileInfo.Extension);
            if (file != null)
            {
                file.Load(fileInfo.FullName);
                file.ReplaceText(TargetString, ReplaceString);
                file.Save(fileInfo.FullName);
            }
        }
    }
}
