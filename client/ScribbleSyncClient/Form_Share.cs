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
    public partial class Form_Share : Form
    {
        int id = 0;
        public Form_Share()
        {
            InitializeComponent();
        }
        public Form_Share(int id)
        {
            InitializeComponent();
            this.id = id;
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
        void Refresh()
        {
            Request req = new Request
            {
                action = "/api/note/get_share_list/" + id.ToString(),
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            flowLayoutPanel_shareduser.Controls.Clear();
            foreach (var name in res.share_list)
            {
                Shared_User_Item item = new Shared_User_Item(name);
                item.Width = flowLayoutPanel_shareduser.Width;
                flowLayoutPanel_shareduser.Controls.Add(item);
            }
           
        }
        private void button_share_add_Click(object sender, EventArgs e)
        {
            if (textBox_usershared.Text == "")
                return;
            Request req = new Request { action = "/api/note/edit/" + id.ToString(),
                data = new Data { share_add = textBox_usershared.Text },
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);

            if(res.statuscode != 200)
            {
                MessageBox.Show(res.message);
            }
            Refresh();
        }


        private void button_share_remove_Click(object sender, EventArgs e)
        {
            if (textBox_usershared.Text == "")
                return;
            Request req = new Request
            {
                action = "/api/note/edit/" + id.ToString(),
                data = new Data { share_remove = textBox_usershared.Text },
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);

            if (res.statuscode != 200)
            {
                MessageBox.Show(res.message);
            }
            Refresh();
        }

        private void label_main_Click(object sender, EventArgs e)
        {

        }

        private void Form_Share_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
