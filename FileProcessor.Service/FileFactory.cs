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
    public static class FileFactory
    {
        public static CompanyFile GetInstance(string fileExtention){
            
            switch (fileExtention.ToLower())
            {
                case "doc":
                case "docx":
                    return new DocFile();
                default:
                    // This file type not supported, so continue for next file
                    return null;
            }
        }
    }
}
