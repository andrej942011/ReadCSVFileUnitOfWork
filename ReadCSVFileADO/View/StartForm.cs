using ReadCSVFileADO.Common;
using ReadCSVFileADO.DataBase.DataSets;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.RepositorySQLServer.Interface;
using ReadCSVFileADO.Services;
using ReadCSVFileADO.Services.Interface;
using ReadCSVFileADO.UnitOfWorkSQLServer;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadCSVFileADO.ReadFile.Document;
using ReadCSVFileADO.View;

namespace ReadCSVFileADO.View
{
    public partial class StartForm : Form
    {
        private IUnitOfWork unitOfWork1;
        private ServicesDB servicesDb;
        public StartForm()
        {
            InitializeComponent();
            unitOfWork1 = new UnitOfWorkSqlServer();
            servicesDb = new ServicesDB(unitOfWork1);
        }


        private void btInformationForm_Click(object sender, EventArgs e)
        {
            CreateInformationForm informationForm = new CreateInformationForm(servicesDb);
            informationForm.ShowDialog();
        }

        private void btInformationUsers_Click(object sender, EventArgs e)
        {
            InformationUsersFrom informationUsersFrom = new InformationUsersFrom(servicesDb);
            informationUsersFrom.ShowDialog();
        }

        private void btConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.ShowDialog();
        }
    }
}
