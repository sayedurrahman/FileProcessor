using System;
using System.Collections.Generic;
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
        
        public void Process(){
            /*
             * Open repo
             * Get list of file
             * foreach file
             *      get the instance of IFile
             *      instance.IFileLoader.Load()
             *      instance.IFIleProcesser.Process()
             *      instance.IFileSaver.Save()
             * */

        }


    }
}
