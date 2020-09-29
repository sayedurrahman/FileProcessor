using FileProcessor.Service.Classes;

namespace FileProcessor.Service
{
    public static class FileFactory
    {
        public static CompanyFile GetInstance(string fileExtention){
            
            switch (fileExtention.ToLower())
            {
                case ".doc":
                case ".docx":
                    return new DocFile();
                default:
                    // This file type not supported, so continue for next file
                    return null;
            }
        }
    }
}
