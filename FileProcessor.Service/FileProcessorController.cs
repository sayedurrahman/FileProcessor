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
        public FileProcessorController(string repositoryPath)
        {
            RepositoryPath = repositoryPath;
        }
        
        public void UpdateCompanyName(){
            if(Directory.Exists(RepositoryPath)){
                foreach(string fileName in Directory.GetFiles(RepositoryPath)){
                    CompanyFile file = FileFactory.GetInstance(fileName);
                    if (file != null)
                    {
                        file.Load();
                        file.Process();
                        file.Save();
                    }
                }
            }
        }
    }
}
