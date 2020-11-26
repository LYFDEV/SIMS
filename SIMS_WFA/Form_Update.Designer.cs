
namespace SIMS_WFA
{
    partial class Form_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update));
            this.tb_PN = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_PN = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_prompt = new System.Windows.Forms.Label();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.tb_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_PN
            // 
            this.tb_PN.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.tb_PN.Location = new System.Drawing.Point(111, 100);
            this.tb_PN.Name = "tb_PN";
            this.tb_PN.Size = new System.Drawing.Size(203, 31);
            this.tb_PN.TabIndex = 27;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.tb_Name.Location = new System.Drawing.Point(111, 54);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(203, 31);
            this.tb_Name.TabIndex = 26;
            // 
            // lb_PN
            // 
            this.lb_PN.AutoSize = true;
            this.lb_PN.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lb_PN.Location = new System.Drawing.Point(17, 103);
            this.lb_PN.Name = "lb_PN";
            this.lb_PN.Size = new System.Drawing.Size(88, 25);
            this.lb_PN.TabIndex = 25;
            this.lb_PN.Text = "联系方式";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lb_Name.Location = new System.Drawing.Point(17, 57);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(50, 25);
            this.lb_Name.TabIndex = 24;
            this.lb_Name.Text = "姓名";
            // 
            // lb_prompt
            // 
            this.lb_prompt.AutoSize = true;
            this.lb_prompt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_prompt.Location = new System.Drawing.Point(17, 12);
            this.lb_prompt.Name = "lb_prompt";
            this.lb_prompt.Size = new System.Drawing.Size(297, 25);
            this.lb_prompt.TabIndex = 23;
            this.lb_prompt.Text = "目前仅支持通过姓名更新联系方式";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.bt_Clear.Location = new System.Drawing.Point(197, 162);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(117, 42);
            this.bt_Clear.TabIndex = 22;
            this.bt_Clear.Text = "清除内容";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_Update
            // 
            this.tb_Update.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.tb_Update.Location = new System.Drawing.Point(22, 162);
            this.tb_Update.Name = "tb_Update";
            this.tb_Update.Size = new System.Drawing.Size(117, 42);
            this.tb_Update.TabIndex = 21;
            this.tb_Update.Text = "更新信息";
            this.tb_Update.UseVisualStyleBackColor = true;
            this.tb_Update.Click += new System.EventHandler(this.tb_Update_Click);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 217);
            this.Controls.Add(this.tb_PN);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_PN);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_prompt);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.tb_Update);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Update";
            this.Text = "更新学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_PN;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_PN;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_prompt;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button tb_Update;
    }
}