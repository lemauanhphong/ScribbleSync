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
using System.Windows.Controls;

namespace ScribbleSyncClient
{
    public partial class Form_CreateNewNote : Form
    {
        public string name = String.Empty;
        public int template_id = 0;
        public Form_CreateNewNote()
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
        private void button_create_Click(object sender, EventArgs e)
        {
            name = textBox_name.Text;
            template_id = ((templateItem)comboBox_template.Items[comboBox_template.SelectedIndex]).id;
            this.Close();
        }

        private void Form_CreateNewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private List<templateItem> GetTemplateList()
        {
            Request req = new Request() { action = "/api/template", token = Connects.token };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);

            return res.items;
        }
        private void Form_CreateNewNote_Load(object sender, EventArgs e)
        {
            var templateidlist = GetTemplateList();
            BindingList<templateItem>  list = new BindingList<templateItem>();
            comboBox_template.DisplayMember = "name";
            comboBox_template.ValueMember = "id";
            list.Add(new templateItem { id = 0, name = "None" });
            foreach (var template in templateidlist)
            {
                list.Add(template);
            }
            comboBox_template.DataSource = list;
            comboBox_template.DisplayMember = "name";
            comboBox_template.ValueMember = "id";
        }
    }
}
