using FileProcessor.Service.Interfaces;
using System;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class DocFileLoader : IFileLoader
    {
        public dynamic Load()
        {
            Application ap = new Application();
            return ap.Documents.Open(@"C:\Test\NewDocument.docx");
            
        }
    }
}
