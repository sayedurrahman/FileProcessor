using FileProcessor.Service.Interfaces;
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
            Loader = new DocFileLoader(path);
            Processer = new DocFileProcessor(matchString, replaceString);
            Saver = new DocFileSaver();
        }
    }
}
