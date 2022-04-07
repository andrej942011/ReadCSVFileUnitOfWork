using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadCSVFileADO.ReadFile.Interface;
using ReadCSVFileADO.ReadFile.Models;

namespace ReadCSVFileADO.ReadFile.Document
{
    public class CSVDocument : IReadDocument
    {
        private String fileName;
        public CSVDocument(string fileName)
        {
            this.fileName = fileName;
        }
        public List<ContactModel> ReadFile()
        {
            List<ContactModel> resturns = new List<ContactModel>();
            try
            {
                string[] lines = File.ReadAllLines(fileName, Encoding.Default);
                for (int i = 1; i < lines.Length; i++)
                {
                    var items = lines[i].Split(new char[] { ';' });
                    resturns.Add(new ContactModel()
                    {
                        Phone = ValidationPhoneNumber(items[0]),//items[0], //валидация номера !!
                        LastName = items[1],
                        FirstName = items[2],
                        MiddleName = items[3],
                        Category = items[4],
                        Gender = items[5],
                        City = ValidationCity(items[6]),//items[6],
                        DateOfBirth = ConverTime(items[7])
                    });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return resturns;
        }

        private Nullable<DateTime> ConverTime(string time)
        {
            Nullable<DateTime> dt = null;
            try
            {
                dt = Convert.ToDateTime(time);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return dt;
        }

        public string ValidationCity(string city)
        {
            var arrChar = city.ToCharArray();
            bool[] statusBools = new bool[arrChar.Length];
            bool statusR = true;

            for (int i = 0; i < arrChar.Length; i++)
                statusBools[i] = ValidateChar(arrChar[i]);

            foreach (var status in statusBools)
            {
                if (status == false)
                    statusR = false;
            }

            if (statusR)
                return city;
            else
                return "";
        }

        private bool ValidateChar(char c)
        {
            var pattern = $"\\w|-"; //$"\\w";
            var status = Regex.IsMatch(c.ToString(), pattern);
            return status;
        }

        private string ValidationPhoneNumber(string number)
        {
            var outNumber = new string(number.Where(c=>char.IsDigit(c)).ToArray());
            if (outNumber.Length == 9)
                outNumber = "";

            return outNumber;
        }
    }
}
