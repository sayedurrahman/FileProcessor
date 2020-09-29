namespace FileProcessor.Service.Classes
{
    public class DocFile : CompanyFile
    {
        public DocFile()
        {
            Loader = new DocFileLoader();
            Processer = new DocFileTextReplacer();
            Saver = new DocFileSaver();
        }
    }
}
