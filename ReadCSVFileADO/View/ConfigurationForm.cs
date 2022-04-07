using ReadCSVFileADO.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadCSVFileADO.View
{
    public partial class ConfigurationForm : Form
    {
        Configuration configuration;
        public ConfigurationForm()
        {
            InitializeComponent();

            var config = new XMLConfig("configuration");
            configuration = config.ReadFile<Configuration>();
            if(configuration != null)
            {
                tbHostName.Text = configuration.ServerName;
                if (configuration.СurrentСar)
                {
                    checkBoxHostName.CheckState = CheckState.Checked;
                }
            }
        }

        private void buttonWriteConfig_Click(object sender, EventArgs e)
        {
            var config = new XMLConfig("configuration");
            Configuration configuration = new Configuration()
            {
                ServerName = tbHostName.Text,
                ConnectionString = "Server={0}\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=true;",
                СurrentСar = checkBoxHostName.Checked,
                EndSt = "aaa"

            };
            config.WriteFile<Configuration>(configuration);
        }
    }
}
