
namespace SIMS_WFA
{
    partial class Form_Retrieve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Retrieve));
            this.tb_StdNum = new System.Windows.Forms.TextBox();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.lb_StdNum = new System.Windows.Forms.Label();
            this.label_prompt = new System.Windows.Forms.Label();
            this.btn_ClearResult = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Retrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_StdNum
            // 
            this.tb_StdNum.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.tb_StdNum.Location = new System.Drawing.Point(68, 66);
            this.tb_StdNum.Name = "tb_StdNum";
            this.tb_StdNum.Size = new System.Drawing.Size(334, 31);
            this.tb_StdNum.TabIndex = 27;
            // 
            // listBox_Result
            // 
            this.listBox_Result.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 24;
            this.listBox_Result.Location = new System.Drawing.Point(12, 129);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(676, 340);
            this.listBox_Result.TabIndex = 26;
            // 
            // lb_StdNum
            // 
            this.lb_StdNum.AutoSize = true;
            this.lb_StdNum.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lb_StdNum.Location = new System.Drawing.Point(12, 69);
            this.lb_StdNum.Name = "lb_StdNum";
            this.lb_StdNum.Size = new System.Drawing.Size(50, 25);
            this.lb_StdNum.TabIndex = 25;
            this.lb_StdNum.Text = "学号";
            // 
            // label_prompt
            // 
            this.label_prompt.AutoSize = true;
            this.label_prompt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_prompt.Location = new System.Drawing.Point(242, 16);
            this.label_prompt.Name = "label_prompt";
            this.label_prompt.Size = new System.Drawing.Size(202, 25);
            this.label_prompt.TabIndex = 24;
            this.label_prompt.Text = "通过学号查询学生信息";
            // 
            // btn_ClearResult
            // 
            this.btn_ClearResult.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btn_ClearResult.Location = new System.Drawing.Point(205, 487);
            this.btn_ClearResult.Name = "btn_ClearResult";
            this.btn_ClearResult.Size = new System.Drawing.Size(280, 41);
            this.btn_ClearResult.TabIndex = 23;
            this.btn_ClearResult.Text = "清除查询结果";
            this.btn_ClearResult.UseVisualStyleBackColor = true;
            this.btn_ClearResult.Click += new System.EventHandler(this.btn_ClearResult_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btn_Clear.Location = new System.Drawing.Point(578, 61);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 41);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "清除内容";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Retrieve
            // 
            this.btn_Retrieve.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btn_Retrieve.Location = new System.Drawing.Point(438, 61);
            this.btn_Retrieve.Name = "btn_Retrieve";
            this.btn_Retrieve.Size = new System.Drawing.Size(110, 41);
            this.btn_Retrieve.TabIndex = 21;
            this.btn_Retrieve.Text = "查询信息";
            this.btn_Retrieve.UseVisualStyleBackColor = true;
            this.btn_Retrieve.Click += new System.EventHandler(this.btn_Retrieve_Click);
            // 
            // Form_Retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 545);
            this.Controls.Add(this.tb_StdNum);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.lb_StdNum);
            this.Controls.Add(this.label_prompt);
            this.Controls.Add(this.btn_ClearResult);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Retrieve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Retrieve";
            this.Text = "查询学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_StdNum;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.Label lb_StdNum;
        private System.Windows.Forms.Label label_prompt;
        private System.Windows.Forms.Button btn_ClearResult;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Retrieve;
    }
}