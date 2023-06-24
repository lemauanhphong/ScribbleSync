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
    public partial class List_Note_Item : UserControl
    {
        int id = 0;
        bool shared = false;
        Color orgColor = SystemColors.Info;
        #region Properties
        private string _name;
        private string _mdate;

        public string NoteName
        {
            get { return _name; }
            set { _name = value; label_name.Text = value; }
        }
        public string ModifiedDate
        {
            get { return _mdate; }
            set { _mdate = value; label_date.Text = value; }
        }
        #endregion
        public List_Note_Item()
        {
            InitializeComponent();
        }
        public List_Note_Item(int id, bool shared = false)
        {
            InitializeComponent();
            this.id = id;
            this.shared = shared;
            Refresh();
            ContextMenuStrip s = new ContextMenuStrip();

            // add one right click menu item named as hello           
            ToolStripMenuItem delete = new ToolStripMenuItem();
            delete.Text = "Delete Permanently";

            // add the clickevent of hello item
            delete.Click += delete_Click;

            // add the item in right click menu
            s.Items.Add(delete);

            // attach the right click menu with form
            this.ContextMenuStrip = s;
        }
        void delete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello Clicked");
            Request req = new Request
            {
                action = "/api/note/delete/" + id.ToString(),
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            if (res.statuscode != 200)
            {
                MessageBox.Show(res.message);
            }
            else
            this.Visible = false;
        }
        public void Refresh()
        {
            Request req = new Request
            {
                action = "/api/note/" + id.ToString(),
                token = Connects.token
            };
            string msg = Connects.SendAndReceiveServer(JsonSerializer.Serialize(req));
            Response res = JsonSerializer.Deserialize<Response>(msg);
            label_name.Text = res.name;
            label_date.Text = "";
        }
        private void List_Note_Item_MouseEnter(object sender, EventArgs e)
        {
            orgColor = this.BackColor;
            this.BackColor = Color.Gold;
        }

        private void List_Note_Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = orgColor;
        }


        private void List_Note_Item_Click(object sender, EventArgs e)
        {
            if (this.shared == false)
            {
                Form_Note f = new Form_Note(this, id);
                //this.Hide();
                f.ShowDialog();
            }
            else
            {
                Form_Read_only_Note f = new Form_Read_only_Note(this, id);
                f.ShowDialog();
            }
            Refresh();
        }

        private void List_Note_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
