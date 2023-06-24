
namespace ScribbleSyncClient
{
    partial class Form_Read_only_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Read_only_Note));
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.webView_preview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label_readonly = new System.Windows.Forms.Label();
            this.label_noteName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(724, 1);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(33, 43);
            this.button_Minimize.TabIndex = 11;
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
            this.button_Close.Location = new System.Drawing.Point(760, 1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(39, 43);
            this.button_Close.TabIndex = 12;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // webView_preview
            // 
            this.webView_preview.AllowExternalDrop = true;
            this.webView_preview.CreationProperties = null;
            this.webView_preview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_preview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webView_preview.Location = new System.Drawing.Point(0, 95);
            this.webView_preview.Name = "webView_preview";
            this.webView_preview.Size = new System.Drawing.Size(800, 805);
            this.webView_preview.TabIndex = 13;
            this.webView_preview.ZoomFactor = 1D;
            // 
            // label_readonly
            // 
            this.label_readonly.AutoSize = true;
            this.label_readonly.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_readonly.Location = new System.Drawing.Point(12, 9);
            this.label_readonly.Name = "label_readonly";
            this.label_readonly.Size = new System.Drawing.Size(79, 23);
            this.label_readonly.TabIndex = 14;
            this.label_readonly.Text = "Read-only";
            // 
            // label_noteName
            // 
            this.label_noteName.AutoSize = true;
            this.label_noteName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noteName.Location = new System.Drawing.Point(48, 42);
            this.label_noteName.Name = "label_noteName";
            this.label_noteName.Size = new System.Drawing.Size(176, 37);
            this.label_noteName.TabIndex = 15;
            this.label_noteName.Text = "Note\'s name";
            // 
            // Form_Read_only_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.label_noteName);
            this.Controls.Add(this.label_readonly);
            this.Controls.Add(this.webView_preview);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Read_only_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Read_only_Note";
            this.Load += new System.EventHandler(this.Form_Read_only_Note_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.webView_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_preview;
        private System.Windows.Forms.Label label_readonly;
        private System.Windows.Forms.Label label_noteName;
    }
}