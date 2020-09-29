using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Service.Interfaces
{
    public interface IFileSaver
    {
        void Save(object document, string fileName);
    }
}
