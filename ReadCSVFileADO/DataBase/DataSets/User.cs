using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadCSVFileADO.DataBase.DataSets.JoinDataSets;


namespace ReadCSVFileADO.DataBase.DataSets
{
    public class User:UserJoin
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string LastName { get; set; } //Фамилия
        public string FirstName { get; set; } //Имя
        public string MiddleName { get; set; } //Отчество

        public int? CategoryId { get; set; }
        //public Category Category { get; set; }

        public int? GenderId { get; set; }
        //public Gender Gender { get; set; }

        public int? CityId { get; set; }
        //public City City { get; set; }

        public string DateOfBirth { get; set; } //Дата рождения

        public int? InformationId { get; set; }
        //public Information Information { get; set; } //М:1
    }
}
