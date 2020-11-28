
namespace SIMS_WFA
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lb_AdminName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_AdminName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("宋体", 10.8F);
            this.btn_Login.Location = new System.Drawing.Point(42, 138);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 36);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("宋体", 10.8F);
            this.btn_Register.Location = new System.Drawing.Point(241, 138);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 36);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lb_AdminName
            // 
            this.lb_AdminName.AutoSize = true;
            this.lb_AdminName.Font = new System.Drawing.Font("宋体", 10.8F);
            this.lb_AdminName.Location = new System.Drawing.Point(38, 29);
            this.lb_AdminName.Name = "lb_AdminName";
            this.lb_AdminName.Size = new System.Drawing.Size(66, 19);
            this.lb_AdminName.TabIndex = 2;
            this.lb_AdminName.Text = "用户名";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("宋体", 10.8F);
            this.lb_Password.Location = new System.Drawing.Point(38, 81);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(67, 19);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "密  码";
            // 
            // tb_AdminName
            // 
            this.tb_AdminName.Font = new System.Drawing.Font("宋体", 10.8F);
            this.tb_AdminName.Location = new System.Drawing.Point(110, 23);
            this.tb_AdminName.Name = "tb_AdminName";
            this.tb_AdminName.Size = new System.Drawing.Size(206, 28);
            this.tb_AdminName.TabIndex = 4;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("宋体", 10.8F);
            this.tb_Password.Location = new System.Drawing.Point(111, 75);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(205, 28);
            this.tb_Password.TabIndex = 5;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("宋体", 10.8F);
            this.btn_Clear.Location = new System.Drawing.Point(144, 138);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 36);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 220);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_AdminName);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_AdminName);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lb_AdminName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_AdminName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Clear;
    }
}