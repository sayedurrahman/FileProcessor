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
        private string MatchString { get; set; }
        private string ReplaceString { get; set; }
        public DocFileProcessor(string matchString, string replaceString)
        {
            MatchString = matchString;
            ReplaceString = replaceString;
        }

        public void Process(dynamic document)
        {
            document.Replace(MatchString, ReplaceString, false, true);
        }
    }
}
