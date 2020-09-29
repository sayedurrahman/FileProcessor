using FileProcessor.Service.Interfaces;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class DocFile : CompanyFile
    {
        public DocFile()
        {
            Loader = new DocFileLoader();
            Processer = new DocFileProcessor();
            Saver = new DocFileSaver();
        }        
    }
}
