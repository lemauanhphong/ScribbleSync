using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
namespace ScribbleSyncClient
{
    public partial class Form_Change_Profile : Form
    {
        public Form_Change_Profile()
        {
            InitializeComponent();
            textBox_username.Text = Connects.username;
            this.Icon = Properties.Resources.Logo2;
            pictureBox_avatar.Image = Properties.Resources.Avatar;
            Refresh();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form_Control_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        public void Refresh()
        {
            Request req = new Request { action = "/api/profile", token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            
            Response res = JsonSerializer.Deserialize<Response>(msg);
            //MessageBox.Show(msg);
            if (res.avatar != null && res.avatar != "")
            {
                byte[] imageBytes = Convert.FromBase64String(res.avatar);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox_avatar.Image = image;
                }
            }
        }
        private void Form_Control_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_changepwd_Click(object sender, EventArgs e)
        {
            Form_Change_Password f = new Form_Change_Password();
            f.ShowDialog();
        }

        private void button_changeavatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            ofd.ShowDialog();
            byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
            string base64String = Convert.ToBase64String(imageBytes);
            Data dt = new Data {new_avatar = base64String};
            Request req = new Request { action = "/api/profile/update", data = dt, token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            MessageBox.Show("Success");
            Refresh();

        }
    }
}
