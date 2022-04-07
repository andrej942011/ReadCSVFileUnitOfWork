
namespace ReadCSVFileADO.View
{
    partial class InformationUsersFrom
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleNameUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfBirthUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.41237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.58763F));
            this.tableLayoutPanel1.Controls.Add(this.usersGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.informationGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usersGrid
            // 
            this.usersGrid.AutoGenerateColumns = false;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdColumn,
            this.PhoneUserColumn,
            this.LastNameUserColumn,
            this.FirstNameUserColumn,
            this.MiddleNameUserColumn,
            this.CategoryNameColumn,
            this.CityNameColumn,
            this.GenderNameColumn,
            this.DataOfBirthUserColumn});
            this.usersGrid.DataSource = this.UsersBindingSource;
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGrid.Location = new System.Drawing.Point(271, 3);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(609, 222);
            this.usersGrid.TabIndex = 1;
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.DataPropertyName = "Id";
            this.UserIdColumn.HeaderText = "Id";
            this.UserIdColumn.Name = "UserIdColumn";
            this.UserIdColumn.Width = 50;
            // 
            // PhoneUserColumn
            // 
            this.PhoneUserColumn.DataPropertyName = "Phone";
            this.PhoneUserColumn.HeaderText = "Номер телефона";
            this.PhoneUserColumn.Name = "PhoneUserColumn";
            // 
            // LastNameUserColumn
            // 
            this.LastNameUserColumn.DataPropertyName = "LastName";
            this.LastNameUserColumn.HeaderText = "Фамилия";
            this.LastNameUserColumn.Name = "LastNameUserColumn";
            // 
            // FirstNameUserColumn
            // 
            this.FirstNameUserColumn.DataPropertyName = "FirstName";
            this.FirstNameUserColumn.HeaderText = "Имя";
            this.FirstNameUserColumn.Name = "FirstNameUserColumn";
            // 
            // MiddleNameUserColumn
            // 
            this.MiddleNameUserColumn.DataPropertyName = "MiddleName";
            this.MiddleNameUserColumn.HeaderText = "Отчество";
            this.MiddleNameUserColumn.Name = "MiddleNameUserColumn";
            // 
            // CategoryNameColumn
            // 
            this.CategoryNameColumn.DataPropertyName = "CategoryName";
            this.CategoryNameColumn.HeaderText = "Категория";
            this.CategoryNameColumn.Name = "CategoryNameColumn";
            // 
            // CityNameColumn
            // 
            this.CityNameColumn.DataPropertyName = "CityName";
            this.CityNameColumn.HeaderText = "Город";
            this.CityNameColumn.Name = "CityNameColumn";
            // 
            // GenderNameColumn
            // 
            this.GenderNameColumn.DataPropertyName = "GenderName";
            this.GenderNameColumn.HeaderText = "Пол";
            this.GenderNameColumn.Name = "GenderNameColumn";
            this.GenderNameColumn.Width = 40;
            // 
            // DataOfBirthUserColumn
            // 
            this.DataOfBirthUserColumn.DataPropertyName = "DateOfBirth";
            this.DataOfBirthUserColumn.HeaderText = "Дата рождения ";
            this.DataOfBirthUserColumn.Name = "DataOfBirthUserColumn";
            this.DataOfBirthUserColumn.Width = 150;
            // 
            // informationGrid
            // 
            this.informationGrid.AutoGenerateColumns = false;
            this.informationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dateColumn,
            this.patchColumn,
            this.commentColumn});
            this.informationGrid.DataSource = this.InformationBindingSource;
            this.informationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationGrid.Location = new System.Drawing.Point(3, 3);
            this.informationGrid.Name = "informationGrid";
            this.informationGrid.Size = new System.Drawing.Size(262, 222);
            this.informationGrid.TabIndex = 0;
            this.informationGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.informationGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InformationId";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // dateColumn
            // 
            this.dateColumn.DataPropertyName = "DateCreate";
            this.dateColumn.HeaderText = "Дата";
            this.dateColumn.Name = "dateColumn";
            // 
            // patchColumn
            // 
            this.patchColumn.DataPropertyName = "FilePath";
            this.patchColumn.HeaderText = "Путь";
            this.patchColumn.Name = "patchColumn";
            this.patchColumn.Width = 200;
            // 
            // commentColumn
            // 
            this.commentColumn.DataPropertyName = "Comment";
            this.commentColumn.HeaderText = "Коммент";
            this.commentColumn.Name = "commentColumn";
            // 
            // InformationBindingSource
            // 
            this.InformationBindingSource.DataMember = "Information";
            // 
            // InformationUsersFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InformationUsersFrom";
            this.Text = "InformationUsersFrom";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView informationGrid;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.BindingSource InformationBindingSource;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleNameUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfBirthUserColumn;
    }
}