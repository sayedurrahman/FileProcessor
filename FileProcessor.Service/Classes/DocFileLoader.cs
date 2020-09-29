using FileProcessor.Service.Interfaces;
using Spire.Doc;
using Spire.Pdf.Exporting.XPS.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class DocFileLoader : IFileLoader
    {
        private string Path { get; set; }
        public DocFileLoader(string path)
        {
            Path = path;
        }

        public dynamic Load()
        {
            Document document = new Document();
            document.LoadFromFile(Path);
            return document;
        }
    }
}
