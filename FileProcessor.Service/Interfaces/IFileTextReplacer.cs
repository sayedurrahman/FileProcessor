namespace FileProcessor.Service.Interfaces
{
    public interface IFileTextReplacer
    {
        void ReplaceText(object document, string matchString, string replaceString);
    }
}
