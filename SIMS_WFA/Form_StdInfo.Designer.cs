
namespace SIMS_WFA
{
    partial class Form_StdInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StdInfo));
            this.menuStrip_CRUD = new System.Windows.Forms.MenuStrip();
            this.Menu_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Retrieve = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB2018StdInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_2018Std_InfoDataSet = new SIMS_WFA.DB_2018Std_InfoDataSet();
            this.t_PerInfoTableAdapter = new SIMS_WFA.DB_2018Std_InfoDataSetTableAdapters.T_PerInfoTableAdapter();
            this.menuStrip_CRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2018StdInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_2018Std_InfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_CRUD
            // 
            this.menuStrip_CRUD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.menuStrip_CRUD.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_CRUD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Create,
            this.Menu_Retrieve,
            this.Menu_Update,
            this.Menu_Delete,
            this.Menu_Refresh});
            this.menuStrip_CRUD.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_CRUD.Name = "menuStrip_CRUD";
            this.menuStrip_CRUD.Size = new System.Drawing.Size(1119, 35);
            this.menuStrip_CRUD.TabIndex = 3;
            this.menuStrip_CRUD.Text = "menuStrip1";
            // 
            // Menu_Create
            // 
            this.Menu_Create.Name = "Menu_Create";
            this.Menu_Create.Size = new System.Drawing.Size(66, 31);
            this.Menu_Create.Text = "添加";
            this.Menu_Create.Click += new System.EventHandler(this.Menu_Create_Click);
            // 
            // Menu_Retrieve
            // 
            this.Menu_Retrieve.Name = "Menu_Retrieve";
            this.Menu_Retrieve.Size = new System.Drawing.Size(66, 31);
            this.Menu_Retrieve.Text = "查询";
            this.Menu_Retrieve.Click += new System.EventHandler(this.Menu_Retrieve_Click);
            // 
            // Menu_Update
            // 
            this.Menu_Update.Name = "Menu_Update";
            this.Menu_Update.Size = new System.Drawing.Size(66, 31);
            this.Menu_Update.Text = "更新";
            this.Menu_Update.Click += new System.EventHandler(this.Menu_Update_Click);
            // 
            // Menu_Delete
            // 
            this.Menu_Delete.Name = "Menu_Delete";
            this.Menu_Delete.Size = new System.Drawing.Size(66, 31);
            this.Menu_Delete.Text = "删除";
            this.Menu_Delete.Click += new System.EventHandler(this.Menu_Delete_Click);
            // 
            // Menu_Refresh
            // 
            this.Menu_Refresh.Name = "Menu_Refresh";
            this.Menu_Refresh.Size = new System.Drawing.Size(66, 31);
            this.Menu_Refresh.Text = "刷新";
            this.Menu_Refresh.Click += new System.EventHandler(this.Menu_Refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdNumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.nationDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPerInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 497);
            this.dataGridView1.TabIndex = 4;
            // 
            // stdNumDataGridViewTextBoxColumn
            // 
            this.stdNumDataGridViewTextBoxColumn.DataPropertyName = "StdNum";
            this.stdNumDataGridViewTextBoxColumn.HeaderText = "StdNum";
            this.stdNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdNumDataGridViewTextBoxColumn.Name = "stdNumDataGridViewTextBoxColumn";
            this.stdNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationDataGridViewTextBoxColumn
            // 
            this.nationDataGridViewTextBoxColumn.DataPropertyName = "Nation";
            this.nationDataGridViewTextBoxColumn.HeaderText = "Nation";
            this.nationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationDataGridViewTextBoxColumn.Name = "nationDataGridViewTextBoxColumn";
            this.nationDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // tPerInfoBindingSource
            // 
            this.tPerInfoBindingSource.DataMember = "T_PerInfo";
            this.tPerInfoBindingSource.DataSource = this.dB2018StdInfoDataSetBindingSource;
            // 
            // dB2018StdInfoDataSetBindingSource
            // 
            this.dB2018StdInfoDataSetBindingSource.DataSource = this.dB_2018Std_InfoDataSet;
            this.dB2018StdInfoDataSetBindingSource.Position = 0;
            // 
            // dB_2018Std_InfoDataSet
            // 
            this.dB_2018Std_InfoDataSet.DataSetName = "DB_2018Std_InfoDataSet";
            this.dB_2018Std_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_PerInfoTableAdapter
            // 
            this.t_PerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form_StdInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip_CRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_StdInfo";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.Form_StdInfo_Load);
            this.menuStrip_CRUD.ResumeLayout(false);
            this.menuStrip_CRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2018StdInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_2018Std_InfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_CRUD;
        private System.Windows.Forms.ToolStripMenuItem Menu_Create;
        private System.Windows.Forms.ToolStripMenuItem Menu_Retrieve;
        private System.Windows.Forms.ToolStripMenuItem Menu_Update;
        private System.Windows.Forms.ToolStripMenuItem Menu_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dB2018StdInfoDataSetBindingSource;
        private DB_2018Std_InfoDataSet dB_2018Std_InfoDataSet;
        private System.Windows.Forms.BindingSource tPerInfoBindingSource;
        private DB_2018Std_InfoDataSetTableAdapters.T_PerInfoTableAdapter t_PerInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem Menu_Refresh;
    }
}