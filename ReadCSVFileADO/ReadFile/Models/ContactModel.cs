using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.ReadFile.Models
{
    public class ContactModel
    {
        //[Index(0)]
        public string Phone { get; set; }
        //[Index(1)]
        public string LastName { get; set; } //Фамилия
        public string FirstName { get; set; } //Имя
        public string MiddleName { get; set; } //Отчество
        //[Index(4)]
        public string Category { get; set; }
        //[Index(5)]
        public string Gender { get; set; } //пол
        //[Index(6)]
        public string City { get; set; }
        //[Index(7)]
        public Nullable<DateTime> DateOfBirth { get; set; } //Дата рождения
    }
}
