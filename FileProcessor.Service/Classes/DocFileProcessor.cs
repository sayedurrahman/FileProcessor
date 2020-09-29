using FileProcessor.Service.Interfaces;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class DocFileProcessor : IFileProcessor
    {
        public void RenameText(object document, string matchString, string replaceString)
        {
            Document doc= (Document)document;
            doc.Replace(matchString, replaceString, false, true);
        }
    }
}
