
namespace ReadCSVFileADO.View
{
    partial class CreateInformationForm
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
            this.btOpenCsvFile = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btWriting = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOpenCsvFile
            // 
            this.btOpenCsvFile.Location = new System.Drawing.Point(268, 161);
            this.btOpenCsvFile.Name = "btOpenCsvFile";
            this.btOpenCsvFile.Size = new System.Drawing.Size(117, 40);
            this.btOpenCsvFile.TabIndex = 0;
            this.btOpenCsvFile.Text = "Открыть файл csv";
            this.btOpenCsvFile.UseVisualStyleBackColor = true;
            this.btOpenCsvFile.Click += new System.EventHandler(this.btOpenCsvFile_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(12, 25);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(373, 101);
            this.tbComment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Комментарий:";
            // 
            // btWriting
            // 
            this.btWriting.Location = new System.Drawing.Point(187, 161);
            this.btWriting.Name = "btWriting";
            this.btWriting.Size = new System.Drawing.Size(75, 40);
            this.btWriting.TabIndex = 3;
            this.btWriting.Text = "Запись в БД";
            this.btWriting.UseVisualStyleBackColor = true;
            this.btWriting.Click += new System.EventHandler(this.btWriting_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(180, 137);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "label2";
            // 
            // CreateInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 213);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btWriting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.btOpenCsvFile);
            this.Name = "CreateInformationForm";
            this.Text = "Загрузка CSV файла с контактами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateInformationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpenCsvFile;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWriting;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStatus;
    }
}