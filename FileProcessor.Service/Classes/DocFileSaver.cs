using FileProcessor.Service.Interfaces;
using Spire.Doc;

namespace FileProcessor.Service.Classes
{
    public class DocFileSaver : IFileSaver
    {
        public void Save(object document, string fileName)
        {
            Document doc = (Document)document;
            doc.SaveToFile(fileName, FileFormat.Docx);
            doc.Dispose();
        }
    }
}
