namespace FileProcessor.Service.Interfaces
{
    public interface IFileSaver
    {
        void Save(object document, string fileName);
    }
}
