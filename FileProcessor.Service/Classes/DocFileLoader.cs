using FileProcessor.Service.Interfaces;
using Spire.Doc;

namespace FileProcessor.Service.Classes
{
    public class DocFileLoader : IFileLoader
    {
        public object Load(string filePath)
        {
            Document document = new Document();
            document.LoadFromFile(filePath);
            return document;
        }
    }
}
