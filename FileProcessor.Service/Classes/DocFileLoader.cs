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
        public object Load(string filePath)
        {
            Document document = new Document();
            document.LoadFromFile(filePath);
            return document;
        }
    }
}
