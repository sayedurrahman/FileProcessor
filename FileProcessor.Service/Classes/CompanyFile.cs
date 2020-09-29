using FileProcessor.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Classes
{
    public class CompanyFile
    {
        public IFileLoader Loader { get; set; }
        public IFileProcessor Processer { get; set; }
        public IFileSaver Saver { get; set; }

        protected object document;

        public void Load(string path)
        {
            document = Loader.Load(path);
        }

        public void ReplaceText(string matchString, string replaceString)
        {
            if (replaceString.ToLower().Contains(matchString.ToLower()))
            {
                // matchingStrig = Software People, replaceString = Software People Bangladesh
                // First replace all "Software People Bangladesh" with "Software People"
                Processer.RenameText(document, replaceString: matchString, matchString: replaceString);

                // After that replace all "Software People" with "Software People Bangladesh"
            }

            Processer.RenameText(document, matchString, replaceString);
        }

        public void Save(string path)
        {
            Saver.Save(document,path);
        }
    }
}
