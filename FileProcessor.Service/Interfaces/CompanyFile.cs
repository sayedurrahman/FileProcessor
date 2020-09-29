using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Interfaces
{
    public class CompanyFile
    {
        public IFileLoader Loader { get; set; }
        public IFileProcessor Processer { get; set; }
        public IFileSaver Saver { get; set; }

        protected dynamic document;

        public void Load()
        {
            document = Loader.Load();
        }

        public void Process()
        {
            Processer.Process();
        }

        public void Save()
        {
            Saver.Save();
        }
    }
}
