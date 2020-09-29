using FileProcessor.Service.Classes;
using FileProcessor.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service
{
    public class FileProcessorController
    {
        public string RepositoryPath { get; set; }
        public string MatchString { get; set; }
        public string ReplaceString { get; set; }
        public FileProcessorController(string repositoryPath, string oldCompanyName = "Software People", string newCompanyName = "Software People Bangladesh")
        {
            RepositoryPath = repositoryPath;
            MatchString = oldCompanyName;
            ReplaceString = newCompanyName;
        }

        public void UpdateCompanyName()
        {
            if (Directory.Exists(RepositoryPath))
            {
                foreach (string fileName in Directory.GetFiles(RepositoryPath))
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    CompanyFile file = FileFactory.GetInstance(fileInfo.Extension);
                    if (file != null)
                    {
                        file.Load(fileInfo.FullName);
                        file.ReplaceText(MatchString, ReplaceString);
                        file.Save(fileInfo.FullName);
                    }
                }
            }
        }
    }
}
