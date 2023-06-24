
namespace ScribbleSyncClient
{
    partial class Form_CreateNewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateNewNote));
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_formtitle = new System.Windows.Forms.Label();
            this.label_noteName = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_template = new System.Windows.Forms.Label();
            this.comboBox_template = new System.Windows.Forms.ComboBox();
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.AutoSize = true;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimize.Location = new System.Drawing.Point(620, 0);
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
            this.button_Close.Location = new System.Drawing.Point(659, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(39, 43);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_formtitle
            // 
            this.label_formtitle.AutoSize = true;
            this.label_formtitle.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formtitle.Location = new System.Drawing.Point(228, 24);
            this.label_formtitle.Name = "label_formtitle";
            this.label_formtitle.Size = new System.Drawing.Size(256, 47);
            this.label_formtitle.TabIndex = 9;
            this.label_formtitle.Text = "Create New Note";
            // 
            // label_noteName
            // 
            this.label_noteName.AutoSize = true;
            this.label_noteName.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noteName.Location = new System.Drawing.Point(32, 97);
            this.label_noteName.Name = "label_noteName";
            this.label_noteName.Size = new System.Drawing.Size(147, 37);
            this.label_noteName.TabIndex = 9;
            this.label_noteName.Text = "Note\'s name";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(38, 133);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(615, 33);
            this.textBox_name.TabIndex = 10;
            // 
            // label_template
            // 
            this.label_template.AutoSize = true;
            this.label_template.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_template.Location = new System.Drawing.Point(31, 208);
            this.label_template.Name = "label_template";
            this.label_template.Size = new System.Drawing.Size(116, 37);
            this.label_template.TabIndex = 9;
            this.label_template.Text = "Template";
            // 
            // comboBox_template
            // 
            this.comboBox_template.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_template.FormattingEnabled = true;
            this.comboBox_template.Location = new System.Drawing.Point(45, 252);
            this.comboBox_template.Name = "comboBox_template";
            this.comboBox_template.Size = new System.Drawing.Size(608, 33);
            this.comboBox_template.TabIndex = 11;
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(236, 329);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(248, 45);
            this.button_create.TabIndex = 12;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Form_CreateNewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.comboBox_template);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_template);
            this.Controls.Add(this.label_noteName);
            this.Controls.Add(this.label_formtitle);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CreateNewNote";
            this.Text = "Form_CreateNewNote";
            this.Load += new System.EventHandler(this.Form_CreateNewNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Control_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_formtitle;
        private System.Windows.Forms.Label label_noteName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_template;
        private System.Windows.Forms.ComboBox comboBox_template;
        private System.Windows.Forms.Button button_create;
    }
}