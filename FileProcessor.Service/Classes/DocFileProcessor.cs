using FileProcessor.Service.Interfaces;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class DocFileProcessor : IFileTextReplacer
    {
        public void ReplaceText(object document, string matchString, string replaceString)
        {
            Document doc= (Document)document;
            doc.Replace(matchString, replaceString, false, true);
        }
    }
}
