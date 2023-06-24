
namespace ScribbleSyncClient
{
    partial class Form_Share
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Share));
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_main = new System.Windows.Forms.Label();
            this.textBox_usershared = new System.Windows.Forms.TextBox();
            this.button_share_add = new System.Windows.Forms.Button();
            this.button_share_remove = new System.Windows.Forms.Button();
            this.flowLayoutPanel_shareduser = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(524, 2);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(33, 43);
            this.button_Minimize.TabIndex = 9;
            this.button_Minimize.Text = "_";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.AutoSize = true;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(560, 2);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(39, 43);
            this.button_Close.TabIndex = 10;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main.Location = new System.Drawing.Point(176, 34);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(272, 57);
            this.label_main.TabIndex = 18;
            this.label_main.Text = "Share this note";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            // 
            // textBox_usershared
            // 
            this.textBox_usershared.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usershared.Location = new System.Drawing.Point(57, 124);
            this.textBox_usershared.Name = "textBox_usershared";
            this.textBox_usershared.Size = new System.Drawing.Size(500, 33);
            this.textBox_usershared.TabIndex = 19;
            // 
            // button_share_add
            // 
            this.button_share_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_share_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_share_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_share_add.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_share_add.ForeColor = System.Drawing.Color.White;
            this.button_share_add.Location = new System.Drawing.Point(317, 163);
            this.button_share_add.Name = "button_share_add";
            this.button_share_add.Size = new System.Drawing.Size(117, 45);
            this.button_share_add.TabIndex = 20;
            this.button_share_add.Text = "Add";
            this.button_share_add.UseVisualStyleBackColor = false;
            this.button_share_add.Click += new System.EventHandler(this.button_share_add_Click);
            // 
            // button_share_remove
            // 
            this.button_share_remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_share_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_share_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_share_remove.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_share_remove.ForeColor = System.Drawing.Color.White;
            this.button_share_remove.Location = new System.Drawing.Point(440, 163);
            this.button_share_remove.Name = "button_share_remove";
            this.button_share_remove.Size = new System.Drawing.Size(117, 45);
            this.button_share_remove.TabIndex = 20;
            this.button_share_remove.Text = "Remove";
            this.button_share_remove.UseVisualStyleBackColor = false;
            this.button_share_remove.Click += new System.EventHandler(this.button_share_remove_Click);
            // 
            // flowLayoutPanel_shareduser
            // 
            this.flowLayoutPanel_shareduser.AutoScroll = true;
            this.flowLayoutPanel_shareduser.Location = new System.Drawing.Point(57, 240);
            this.flowLayoutPanel_shareduser.Name = "flowLayoutPanel_shareduser";
            this.flowLayoutPanel_shareduser.Size = new System.Drawing.Size(500, 493);
            this.flowLayoutPanel_shareduser.TabIndex = 21;
            // 
            // Form_Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.flowLayoutPanel_shareduser);
            this.Controls.Add(this.button_share_remove);
            this.Controls.Add(this.button_share_add);
            this.Controls.Add(this.textBox_usershared);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Share";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Share";
            this.Load += new System.EventHandler(this.Form_Share_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.TextBox textBox_usershared;
        private System.Windows.Forms.Button button_share_add;
        private System.Windows.Forms.Button button_share_remove;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_shareduser;
    }
}