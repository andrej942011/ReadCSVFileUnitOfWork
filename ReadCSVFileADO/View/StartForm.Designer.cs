namespace ReadCSVFileADO.View
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInformationForm = new System.Windows.Forms.Button();
            this.btInformationUsers = new System.Windows.Forms.Button();
            this.btConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInformationForm
            // 
            this.btInformationForm.Location = new System.Drawing.Point(12, 12);
            this.btInformationForm.Name = "btInformationForm";
            this.btInformationForm.Size = new System.Drawing.Size(141, 41);
            this.btInformationForm.TabIndex = 8;
            this.btInformationForm.Text = "Загрузить файл";
            this.btInformationForm.UseVisualStyleBackColor = true;
            this.btInformationForm.Click += new System.EventHandler(this.btInformationForm_Click);
            // 
            // btInformationUsers
            // 
            this.btInformationUsers.Location = new System.Drawing.Point(13, 59);
            this.btInformationUsers.Name = "btInformationUsers";
            this.btInformationUsers.Size = new System.Drawing.Size(140, 46);
            this.btInformationUsers.TabIndex = 11;
            this.btInformationUsers.Text = "Information Users";
            this.btInformationUsers.UseVisualStyleBackColor = true;
            this.btInformationUsers.Click += new System.EventHandler(this.btInformationUsers_Click);
            // 
            // btConfiguration
            // 
            this.btConfiguration.Location = new System.Drawing.Point(13, 111);
            this.btConfiguration.Name = "btConfiguration";
            this.btConfiguration.Size = new System.Drawing.Size(140, 48);
            this.btConfiguration.TabIndex = 17;
            this.btConfiguration.Text = "Настройки подключения";
            this.btConfiguration.UseVisualStyleBackColor = true;
            this.btConfiguration.Click += new System.EventHandler(this.btConfiguration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 173);
            this.Controls.Add(this.btConfiguration);
            this.Controls.Add(this.btInformationUsers);
            this.Controls.Add(this.btInformationForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btInformationForm;
        private System.Windows.Forms.Button btInformationUsers;
        private System.Windows.Forms.Button btConfiguration;
    }
}

