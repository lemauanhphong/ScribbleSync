using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
namespace ScribbleSyncClient
{
    public partial class Form_Change_Password : Form
    {
        public Form_Change_Password()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form_Control_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
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
            if (textBox_curpwd.Text != Connects.password)
                MessageBox.Show("Current Password is wrong!");
            else if (textBox_newpwd.Text == "")
                MessageBox.Show("Please enter new password!");
            else if (textBox_newpwd.Text != textBox_confirmpwd.Text)
                MessageBox.Show("Confirm password is not match!");
            else
            {
                Data dt = new Data { new_password = textBox_newpwd.Text };
                Request req = new Request { action = "/api/profile/update", data = dt, token = Connects.token };
                string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
                Response res = JsonSerializer.Deserialize<Response>(msg);
                if(res.statuscode == 200)
                {
                    MessageBox.Show("Successfully changed password");
                }
                this.Close();
            }
        }
    }
}
