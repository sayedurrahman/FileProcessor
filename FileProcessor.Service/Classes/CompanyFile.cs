using FileProcessor.Service.Interfaces;

namespace FileProcessor.Service.Classes
{
    public class CompanyFile
    {
        public IFileLoader Loader { get; set; }
        public IFileTextReplacer Processer { get; set; }
        public IFileSaver Saver { get; set; }

        // Converting a reference type to object is not a boxing conversion, it is a reference conversion.
        protected object document;

        public void Load(string path)
        {
            document = Loader.Load(path);
        }

        /// <summary>
        /// Business logic: If we are replacing A with AB then recurring replacing call will generae ABBB...B
        /// So if replaceString contains targetString, replace all replaceString with targetString then again do the reverse
        /// </summary>
        /// <param name="targetString"></param>
        /// <param name="replaceString"></param>
        public void ReplaceText(string targetString, string replaceString)
        {
            if (replaceString.ToLower().Contains(targetString.ToLower()))
            {
                // targetString = Software People, replaceString = Software People Bangladesh
                // First replace all "Software People Bangladesh" with "Software People"
                Processer.ReplaceText(document, replaceString: targetString, matchString: replaceString);

                // After that replace all "Software People" with "Software People Bangladesh"
            }

            Processer.ReplaceText(document, targetString, replaceString);
        }

        public void Save(string path)
        {
            Saver.Save(document, path);
        }
    }
}
