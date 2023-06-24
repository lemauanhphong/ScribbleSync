using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.Json;
namespace ScribbleSyncClient
{
    public partial class Form_Control : Form
    {
        public Form_Control()
        {
            InitializeComponent();
        }
        Form_Login FormLoginCalling = null;
        public Form_Control(Form_Login login)
        {
            InitializeComponent();
            FormLoginCalling = login;
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
        private string GetTemplateContent(int id)
        {
            Request req = new Request { action = "/api/template/" + id.ToString(), token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            return res.template.content;
        }
        private void button_newNote_Click(object sender, EventArgs e)
        {
            Form_CreateNewNote info_form = new Form_CreateNewNote();
            info_form.ShowDialog();
            //Create Note
            if (info_form.name == String.Empty)
            {
                return;
            }
            string template = "";
            if(info_form.template_id != 0)
            {
                template = GetTemplateContent(info_form.template_id);
            }
            Data dt = new Data { name = info_form.name, content = $"# {info_form.name}\n"+template };
            Request req = new Request { action = "/api/note/new", data = dt, token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);

            int id = res.id;
            //Access New Note
            req = new Request { action = "/api/note/" + id.ToString(), token = Connects.token };
            msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            res = JsonSerializer.Deserialize<Response>(msg);

            Form_Note f = new Form_Note(this, info_form.name, res.content, id);
            this.Hide();
            f.ShowDialog();
            //this.Close();
        }

        private void button_open_Click(object sender, EventArgs e)
        {   //Get List
            Request req = new Request { action = "/api/note",token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);

            Form_List_Note f = new Form_List_Note(this, res.id_list);
            this.Hide();
            f.ShowDialog();
        }

        private void button_changeProfile_Click(object sender, EventArgs e)
        {
            Form_Change_Profile f = new Form_Change_Profile();
            f.ShowDialog();
        }

        private void Form_Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormLoginCalling != null)
                FormLoginCalling.Show();
        }
    }
}
