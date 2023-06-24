
namespace ScribbleSyncClient
{
    partial class Form_List_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_List_Note));
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_notelist = new System.Windows.Forms.FlowLayoutPanel();
            this.label_open = new System.Windows.Forms.Label();
            this.textBox_sharedtoken = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(1191, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(41, 45);
            this.button_Minimize.TabIndex = 7;
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
            this.button_Close.Location = new System.Drawing.Point(1238, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(41, 45);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Notes";
            // 
            // flowLayoutPanel_notelist
            // 
            this.flowLayoutPanel_notelist.AutoScroll = true;
            this.flowLayoutPanel_notelist.Location = new System.Drawing.Point(90, 100);
            this.flowLayoutPanel_notelist.Name = "flowLayoutPanel_notelist";
            this.flowLayoutPanel_notelist.Size = new System.Drawing.Size(1100, 405);
            this.flowLayoutPanel_notelist.TabIndex = 10;
            // 
            // label_open
            // 
            this.label_open.AutoSize = true;
            this.label_open.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_open.Location = new System.Drawing.Point(82, 531);
            this.label_open.Name = "label_open";
            this.label_open.Size = new System.Drawing.Size(540, 47);
            this.label_open.TabIndex = 11;
            this.label_open.Text = "Open a public note with shared token";
            // 
            // textBox_sharedtoken
            // 
            this.textBox_sharedtoken.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.textBox_sharedtoken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sharedtoken.Location = new System.Drawing.Point(90, 591);
            this.textBox_sharedtoken.Name = "textBox_sharedtoken";
            this.textBox_sharedtoken.Size = new System.Drawing.Size(961, 33);
            this.textBox_sharedtoken.TabIndex = 12;
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.ForeColor = System.Drawing.Color.White;
            this.button_open.Location = new System.Drawing.Point(1073, 585);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(117, 42);
            this.button_open.TabIndex = 21;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // Form_List_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.textBox_sharedtoken);
            this.Controls.Add(this.label_open);
            this.Controls.Add(this.flowLayoutPanel_notelist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_List_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_List_Note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_List_Note_FormClosed);
            this.Load += new System.EventHandler(this.Form_List_Note_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_List_Note_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_List_Note_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_List_Note_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_notelist;
        private System.Windows.Forms.Label label_open;
        private System.Windows.Forms.TextBox textBox_sharedtoken;
        private System.Windows.Forms.Button button_open;
    }
}