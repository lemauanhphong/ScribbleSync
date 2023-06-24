using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
namespace ScribbleSyncClient
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            textBox_Username.Text = "";
            textBox_Password.Text = "";
            this.Icon = Properties.Resources.Logo2;

        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox_Password_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = false;
        }

        private void pictureBox_Password_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Data dt = new Data { username = textBox_Username.Text, password = textBox_Password.Text };
            Request req = new Request { action = "/api/auth/login", data = dt };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            //MessageBox.Show(msg);
            Response res = JsonSerializer.Deserialize<Response>(msg);
            if (res.statuscode != 200)
                MessageBox.Show(res.message);
            else
            {
                MessageBox.Show("Login successfully");
                Connects.username = textBox_Username.Text;
                Connects.password = textBox_Password.Text;
                Connects.token = res.token;
                this.Hide();
                Form_Control f = new Form_Control(this);
                f.ShowDialog();
                //this.Close();
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Data dt = new Data { username = textBox_Username.Text, password = textBox_Password.Text };
            Request req = new Request { action = "/api/auth/register", data = dt };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            //MessageBox.Show(msg);
            Response res = JsonSerializer.Deserialize<Response>(msg);
            if(res.statuscode != 200)
                MessageBox.Show(res.message);
            else
                MessageBox.Show("Register successfully");

        }
    }
}
