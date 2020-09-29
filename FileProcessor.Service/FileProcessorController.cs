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
            // open repo
            // get file list
            // foreach file
            FileInfo fileInfo = new FileInfo("");
            CompanyFile file = FileFactory.GetInstance(fileInfo);
            file.Load();
            file.Process();
            file.Save();

        }




    }
}
