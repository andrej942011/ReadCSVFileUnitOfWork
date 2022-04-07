using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.Services;
using ReadCSVFileADO.View.BL;

namespace ReadCSVFileADO.View
{
    public partial class InformationUsersFrom : Form
    {
        private InformationUsersBL informationBl;
        private ServicesDB servicesDb;
        public InformationUsersFrom(ServicesDB servicesDb)
        {
            InitializeComponent();
            this.servicesDb = servicesDb;
            informationBl = new InformationUsersBL(servicesDb);

            var informations = servicesDb.InformationService.GetAll();
            InformationBindingSource.DataSource = informations;
        }

        private void informationGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if(informationGrid.Rows[e.RowIndex] != null)
                {
                    DataGridViewRow row = informationGrid.Rows[e.RowIndex];
                    Console.WriteLine(row.Cells[0].Value);
                    var id = Convert.ToInt32( row.Cells[0].Value);

                    UsersBindingSource.DataSource = informationBl.GetInformationId(id);
                }
            }
        }

    }
}
