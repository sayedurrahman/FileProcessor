using FileProcessor.Service.Interfaces;
using Spire.Doc;

namespace FileProcessor.Service.Classes
{
    public class DocFileTextReplacer : IFileTextReplacer
    {
        public void ReplaceText(object document, string matchString, string replaceString)
        {
            Document doc= (Document)document;
            doc.Replace(matchString, replaceString, false, true);
        }
    }
}
