
namespace ReadCSVFileADO.View
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWriteConfig = new System.Windows.Forms.Button();
            this.checkBoxHostName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(124, 12);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(216, 20);
            this.tbHostName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя хоста, \r\nдля подключения:";
            // 
            // buttonWriteConfig
            // 
            this.buttonWriteConfig.Location = new System.Drawing.Point(265, 51);
            this.buttonWriteConfig.Name = "buttonWriteConfig";
            this.buttonWriteConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteConfig.TabIndex = 2;
            this.buttonWriteConfig.Text = "Применить";
            this.buttonWriteConfig.UseVisualStyleBackColor = true;
            this.buttonWriteConfig.Click += new System.EventHandler(this.buttonWriteConfig_Click);
            // 
            // checkBoxHostName
            // 
            this.checkBoxHostName.AutoSize = true;
            this.checkBoxHostName.Location = new System.Drawing.Point(94, 61);
            this.checkBoxHostName.Name = "checkBoxHostName";
            this.checkBoxHostName.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHostName.TabIndex = 3;
            this.checkBoxHostName.Text = "да/нет";
            this.checkBoxHostName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущий хост:";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 84);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxHostName);
            this.Controls.Add(this.buttonWriteConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHostName);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWriteConfig;
        private System.Windows.Forms.CheckBox checkBoxHostName;
        private System.Windows.Forms.Label label2;
    }
}