using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.DataBase.DataSets
{
    public class Information
    {
        public int InformationId { get; set; }
        public DateTime DateCreate { get; set; }
        public string FilePath { get; set; }
        public string Comment { get; set; }
        //public List<User> Users { get; set; } //1:М
    }
}
