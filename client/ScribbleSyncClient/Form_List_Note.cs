using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
namespace ScribbleSyncClient
{
    public partial class Form_List_Note : Form
    {

        public noteIds noteid_list = null;
        public Form_List_Note()
        {
            InitializeComponent();
        }
        public Form_Control FormControlCalling;

        public Form_List_Note(Form_Control control, noteIds id_list)
        {
            InitializeComponent();
            FormControlCalling = control;
            noteid_list = id_list;
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form_List_Note_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_List_Note_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_List_Note_MouseMove(object sender, MouseEventArgs e)
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
        private void Form_List_Note_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < noteid_list.priv.Count; i++)
            {
                List_Note_Item item = new List_Note_Item(noteid_list.priv[i]);
                item.Width = flowLayoutPanel_notelist.Width;
                flowLayoutPanel_notelist.Controls.Add(item);
            }
            for (int i = 0; i < noteid_list.share.Count; i++)
            {
                List_Note_Item item = new List_Note_Item(noteid_list.share[i],true);
                item.Width = flowLayoutPanel_notelist.Width;
                item.BackColor = SystemColors.Info;
                flowLayoutPanel_notelist.Controls.Add(item);
            }
                
            
        }

        private void Form_List_Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormControlCalling != null)
                FormControlCalling.Show();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            Request req = new Request
            {
                action = "/api/note/" + textBox_sharedtoken.Text,
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            if(res.statuscode != 200)
            {
                MessageBox.Show(res.message);
                return;
            }
            Form_Read_only_Note f = new Form_Read_only_Note(this, textBox_sharedtoken.Text);
            f.ShowDialog();

        }
    }
    
}
