using ReadCSVFileADO.ReadFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.ReadFile.Interface
{
    public interface IReadDocument
    {
        List<ContactModel> ReadFile();
    }
}
