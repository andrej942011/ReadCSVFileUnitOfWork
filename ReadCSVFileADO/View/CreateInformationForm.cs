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
using ReadCSVFileADO.ReadFile.Document;
using ReadCSVFileADO.ReadFile.Interface;
using ReadCSVFileADO.ReadFile.Models;
using ReadCSVFileADO.RepositorySQLServer;
using ReadCSVFileADO.Services;
using ReadCSVFileADO.UnitOfWorkSQLServer.Interface;
using ReadCSVFileADO.View.BL;
using ReadCSVFileADO.View.Inferface;

namespace ReadCSVFileADO.View
{
    public partial class CreateInformationForm : Form, IUpdateForm
    {
        private CreateInformationBL informationBl;
        private bool formClose = false;

        public CreateInformationForm(ServicesDB servicesDb)
        {
            InitializeComponent();
            informationBl = new CreateInformationBL(servicesDb, this);
        }

        public void UpdateProcessWriting(int count)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string status = count.ToString();
                if (count < 100)
                {
                    progressBar1.Value = count;
                    labelStatus.Text = status + "%";
                }
                else
                {
                    progressBar1.Value = 0;
                    labelStatus.Text = "Добавлено: "+ status + " записей";
                    formClose = false;
                }
            });
        }

        private void btOpenCsvFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Csv files(*.csv)|*.csv";

            if(openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            informationBl.OpenCsvFile(openFileDialog.FileName);
        }

        private async void btWriting_Click(object sender, EventArgs e)
        {

            if (informationBl.models.Count > 0 && formClose == false)
            {
                formClose = true;
                await Task.Run(() => informationBl.CreateInformation(tbComment.Text));
                //informationBl.CreateInformation(tbComment.Text);
            }
            else if(formClose)
            {
                MessageBox.Show("Идет запись в БД");
            }
            else
            {
                MessageBox.Show("CSV файл не загружен");
            }
            
        }

        private void CreateInformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = formClose; 
            }
        }
    }
}
