
namespace ScribbleSyncClient
{
    partial class Form_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Change_Password));
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.textBox_curpwd = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_confirmpwd = new System.Windows.Forms.TextBox();
            this.button_changepwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.AutoSize = true;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(557, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 45);
            this.button_Close.TabIndex = 17;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(510, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(41, 45);
            this.button_Minimize.TabIndex = 16;
            this.button_Minimize.Text = "_";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // textBox_curpwd
            // 
            this.textBox_curpwd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_curpwd.Location = new System.Drawing.Point(209, 88);
            this.textBox_curpwd.Name = "textBox_curpwd";
            this.textBox_curpwd.Size = new System.Drawing.Size(323, 33);
            this.textBox_curpwd.TabIndex = 21;
            this.textBox_curpwd.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(36, 91);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(167, 25);
            this.label_username.TabIndex = 20;
            this.label_username.Text = "Current password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "New password:";
            // 
            // textBox_newpwd
            // 
            this.textBox_newpwd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newpwd.Location = new System.Drawing.Point(209, 144);
            this.textBox_newpwd.Name = "textBox_newpwd";
            this.textBox_newpwd.Size = new System.Drawing.Size(323, 33);
            this.textBox_newpwd.TabIndex = 21;
            this.textBox_newpwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm:";
            // 
            // textBox_confirmpwd
            // 
            this.textBox_confirmpwd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmpwd.Location = new System.Drawing.Point(209, 203);
            this.textBox_confirmpwd.Name = "textBox_confirmpwd";
            this.textBox_confirmpwd.Size = new System.Drawing.Size(323, 33);
            this.textBox_confirmpwd.TabIndex = 21;
            this.textBox_confirmpwd.UseSystemPasswordChar = true;
            // 
            // button_changepwd
            // 
            this.button_changepwd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changepwd.Location = new System.Drawing.Point(191, 267);
            this.button_changepwd.Name = "button_changepwd";
            this.button_changepwd.Size = new System.Drawing.Size(173, 33);
            this.button_changepwd.TabIndex = 22;
            this.button_changepwd.Text = "Change";
            this.button_changepwd.UseVisualStyleBackColor = true;
            this.button_changepwd.Click += new System.EventHandler(this.button_changepwd_Click);
            // 
            // Form_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.button_changepwd);
            this.Controls.Add(this.textBox_confirmpwd);
            this.Controls.Add(this.textBox_newpwd);
            this.Controls.Add(this.textBox_curpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Change_Password";
            this.Text = "Form_Change_Password";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.TextBox textBox_curpwd;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_confirmpwd;
        private System.Windows.Forms.Button button_changepwd;
    }
}