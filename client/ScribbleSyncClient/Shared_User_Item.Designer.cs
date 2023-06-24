
namespace ScribbleSyncClient
{
    partial class Shared_User_Item
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
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(109, 15);
            this.label_name.MaximumSize = new System.Drawing.Size(700, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(129, 32);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Username";
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.InitialImage = global::ScribbleSyncClient.Properties.Resources.Avatar;
            this.pictureBox_avatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(93, 65);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 4;
            this.pictureBox_avatar.TabStop = false;
            // 
            // Shared_User_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pictureBox_avatar);
            this.Controls.Add(this.label_name);
            this.Name = "Shared_User_Item";
            this.Size = new System.Drawing.Size(669, 65);
            this.Load += new System.EventHandler(this.Shared_User_Item_Load);
            this.MouseEnter += new System.EventHandler(this.Shared_User_Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Shared_User_Item_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
    }
}
