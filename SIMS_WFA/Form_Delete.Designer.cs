
namespace SIMS_WFA
{
    partial class Form_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_StdNum = new System.Windows.Forms.TextBox();
            this.lb_StdNum = new System.Windows.Forms.Label();
            this.lb_prompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btn_Clear.Location = new System.Drawing.Point(314, 146);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(116, 40);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "清除内容";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btn_Delete.Location = new System.Drawing.Point(43, 146);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 40);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "删除信息";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_StdNum
            // 
            this.tb_StdNum.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.tb_StdNum.Location = new System.Drawing.Point(91, 79);
            this.tb_StdNum.Name = "tb_StdNum";
            this.tb_StdNum.Size = new System.Drawing.Size(336, 31);
            this.tb_StdNum.TabIndex = 12;
            // 
            // lb_StdNum
            // 
            this.lb_StdNum.AutoSize = true;
            this.lb_StdNum.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lb_StdNum.Location = new System.Drawing.Point(38, 82);
            this.lb_StdNum.Name = "lb_StdNum";
            this.lb_StdNum.Size = new System.Drawing.Size(50, 25);
            this.lb_StdNum.TabIndex = 11;
            this.lb_StdNum.Text = "学号";
            // 
            // lb_prompt
            // 
            this.lb_prompt.AutoSize = true;
            this.lb_prompt.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lb_prompt.Location = new System.Drawing.Point(38, 31);
            this.lb_prompt.Name = "lb_prompt";
            this.lb_prompt.Size = new System.Drawing.Size(392, 25);
            this.lb_prompt.TabIndex = 10;
            this.lb_prompt.Text = "防止错误操作，仅开放通过学号删除学生信息";
            // 
            // Form_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 216);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_StdNum);
            this.Controls.Add(this.lb_StdNum);
            this.Controls.Add(this.lb_prompt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Delete";
            this.Text = "删除学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_StdNum;
        private System.Windows.Forms.Label lb_StdNum;
        private System.Windows.Forms.Label lb_prompt;
    }
}