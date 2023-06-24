
namespace ScribbleSyncClient
{
    partial class Form_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Note));
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView_preview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox_noteName = new System.Windows.Forms.TextBox();
            this.textBox_sharetoken = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox_input);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 750);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_input.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(793, 750);
            this.richTextBox_input.TabIndex = 0;
            this.richTextBox_input.Text = "";
            this.richTextBox_input.TextChanged += new System.EventHandler(this.richTextBox_input_TextChanged);
            this.richTextBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_input_KeyDown);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(1525, -1);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(33, 43);
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
            this.button_Close.Location = new System.Drawing.Point(1561, -1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(39, 43);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.webView_preview);
            this.panel2.Location = new System.Drawing.Point(799, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 750);
            this.panel2.TabIndex = 1;
            // 
            // webView_preview
            // 
            this.webView_preview.AllowExternalDrop = true;
            this.webView_preview.CreationProperties = null;
            this.webView_preview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_preview.Location = new System.Drawing.Point(0, 0);
            this.webView_preview.Name = "webView_preview";
            this.webView_preview.Size = new System.Drawing.Size(801, 750);
            this.webView_preview.TabIndex = 0;
            this.webView_preview.ZoomFactor = 1D;
            // 
            // textBox_noteName
            // 
            this.textBox_noteName.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_noteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_noteName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_noteName.Location = new System.Drawing.Point(69, 58);
            this.textBox_noteName.Name = "textBox_noteName";
            this.textBox_noteName.Size = new System.Drawing.Size(724, 36);
            this.textBox_noteName.TabIndex = 9;
            this.textBox_noteName.Text = "Note\'s Name";
            this.textBox_noteName.TextChanged += new System.EventHandler(this.textBox_noteName_TextChanged);
            this.textBox_noteName.Enter += new System.EventHandler(this.textBox_noteName_Enter);
            this.textBox_noteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_noteName_KeyDown);
            this.textBox_noteName.Leave += new System.EventHandler(this.textBox_noteName_Leave);
            this.textBox_noteName.MouseHover += new System.EventHandler(this.textBox_noteName_MouseHover);
            // 
            // textBox_sharetoken
            // 
            this.textBox_sharetoken.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_sharetoken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sharetoken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sharetoken.Location = new System.Drawing.Point(835, 68);
            this.textBox_sharetoken.Name = "textBox_sharetoken";
            this.textBox_sharetoken.ReadOnly = true;
            this.textBox_sharetoken.Size = new System.Drawing.Size(681, 26);
            this.textBox_sharetoken.TabIndex = 9;
            this.textBox_sharetoken.Text = "sharetoken";
            // 
            // Form_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.textBox_sharetoken);
            this.Controls.Add(this.textBox_noteName);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Note_FormClosed);
            this.Load += new System.EventHandler(this.Form_Note_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_preview;
        private System.Windows.Forms.TextBox textBox_noteName;
        private System.Windows.Forms.TextBox textBox_sharetoken;
    }
}