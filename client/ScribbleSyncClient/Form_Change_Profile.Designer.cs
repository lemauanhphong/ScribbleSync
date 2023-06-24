
namespace ScribbleSyncClient
{
    partial class Form_Change_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Change_Profile));
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_changepwd = new System.Windows.Forms.Button();
            this.button_changeavatar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.AutoSize = true;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(759, 1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 45);
            this.button_Close.TabIndex = 15;
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
            this.button_Minimize.Location = new System.Drawing.Point(712, 1);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(41, 45);
            this.button_Minimize.TabIndex = 14;
            this.button_Minimize.Text = "_";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.InitialImage = global::ScribbleSyncClient.Properties.Resources.Avatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(60, 78);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(150, 200);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 16;
            this.pictureBox_avatar.TabStop = false;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(334, 20);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(129, 57);
            this.label_menu.TabIndex = 17;
            this.label_menu.Text = "Profile";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(216, 125);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(98, 25);
            this.label_username.TabIndex = 18;
            this.label_username.Text = "Username";
            // 
            // textBox_username
            // 
            this.textBox_username.Enabled = false;
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(318, 117);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(398, 33);
            this.textBox_username.TabIndex = 19;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(216, 183);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(91, 25);
            this.label_password.TabIndex = 18;
            this.label_password.Text = "Password";
            // 
            // button_changepwd
            // 
            this.button_changepwd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changepwd.Location = new System.Drawing.Point(318, 183);
            this.button_changepwd.Name = "button_changepwd";
            this.button_changepwd.Size = new System.Drawing.Size(181, 33);
            this.button_changepwd.TabIndex = 20;
            this.button_changepwd.Text = "Change password";
            this.button_changepwd.UseVisualStyleBackColor = true;
            this.button_changepwd.Click += new System.EventHandler(this.button_changepwd_Click);
            // 
            // button_changeavatar
            // 
            this.button_changeavatar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changeavatar.Location = new System.Drawing.Point(60, 284);
            this.button_changeavatar.Name = "button_changeavatar";
            this.button_changeavatar.Size = new System.Drawing.Size(150, 33);
            this.button_changeavatar.TabIndex = 20;
            this.button_changeavatar.Text = "Change avatar";
            this.button_changeavatar.UseVisualStyleBackColor = true;
            this.button_changeavatar.Click += new System.EventHandler(this.button_changeavatar_Click);
            // 
            // Form_Change_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_changeavatar);
            this.Controls.Add(this.button_changepwd);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.pictureBox_avatar);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Change_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Change_Profile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_changepwd;
        private System.Windows.Forms.Button button_changeavatar;
    }
}