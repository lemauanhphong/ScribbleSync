
namespace ScribbleSyncClient
{
    partial class List_Note_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(876, 28);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(103, 20);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "22/05/2003";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(17, 16);
            this.label_name.MaximumSize = new System.Drawing.Size(700, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(156, 32);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Note\'s name";
            // 
            // List_Note_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_name);
            this.Name = "List_Note_Item";
            this.Size = new System.Drawing.Size(1000, 65);
            this.Load += new System.EventHandler(this.List_Note_Item_Load);
            this.Click += new System.EventHandler(this.List_Note_Item_Click);
            this.MouseEnter += new System.EventHandler(this.List_Note_Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.List_Note_Item_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name;
    }
}
